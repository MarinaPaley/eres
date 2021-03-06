﻿using FluentNHibernate.Mapping;
using ORM.Stageis.Entities;

namespace ORM.Stageis.Map
{
    /// <summary>
    /// План перегона
    /// </summary>
    public class PlanStageMap : ClassMap<PlanStage>
    {
        /// <summary>
        /// 
        /// </summary>
        public PlanStageMap()
        {
            Table("Stage.PlanStage");
            Id(x => x.ID);
            Map(x => x.Radius).Not.Nullable();
            Map(x => x.EndRadius).Not.Nullable();
            References(x => x.Stage).ForeignKey("ID_Stage");

        }
    }
}
