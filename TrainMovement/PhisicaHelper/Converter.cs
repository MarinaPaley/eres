﻿using System;

namespace TrainMovement.PhisicaHelper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Converter
    {
        private const Double g = 9.81;

        private const Double k = 1000;

        private const Double secPerHour = 3600;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="velocityMeterPerSec"></param>
        /// <returns></returns>

        public static Double GetVelocityKmPerHour(Double velocityMeterPerSec)
        {
            return velocityMeterPerSec * secPerHour / k;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="velocityPerKmPerHour"></param>
        /// <returns></returns>
        public static Double GetVelocityMeterPerSec(Double velocityPerKmPerHour)
        {
            return velocityPerKmPerHour * k / secPerHour;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="forceNewton"></param>
        /// <returns></returns>

        public static Double GetForceKgC(Double forceNewton)
        {
            return forceNewton * k / g;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="forceKgC"></param>
        /// <returns></returns>

        public static Double GetForceKN(Double forceKgC)
        {
            return forceKgC * secPerHour / (k * k);
        }
    }
}

