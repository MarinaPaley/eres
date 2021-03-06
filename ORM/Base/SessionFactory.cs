﻿using System;
using NHibernate;
using ORM.Conventions;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace ORM.Base
{
    /// <summary>
    /// 
    /// </summary>
    public static class SessionFactory
    {
        /// <exception cref="ArgumentException">Представлен недопустимый аргумент строки 
        public static ISessionFactory GetSessionFactory()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ConfigurationManager.AppSettings["DatabaseLocation"],
                InitialCatalog = ConfigurationManager.AppSettings["DatabaseName"],
                IntegratedSecurity = true
            };
           
            var configure = MsSqlConfiguration.MsSql2008.ConnectionString(builder.ConnectionString);

            var configuration = Fluently.Configure()
                        .Database(configure)
                        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
                        .Conventions.Add<MyForeignKeyConvention>()
                        .Conventions.Add<MyIdConvention>()
                       )
                        .BuildConfiguration();
            return configuration.BuildSessionFactory();
        }
    }
}
