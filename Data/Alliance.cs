using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ScoutingModels.Data
{
    /// <summary>
    /// The three robot team on each side during a match
    /// -GeoEngel
    /// </summary>
    public class Alliance
    {
        /// <summary>
        /// What determines if the robot is on one alliance or the other
        /// </summary>
        public AllianceColor Color { get; set; }

        /// <summary>
        /// What gives the Alliance its uniqueness
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gives the total score of the given alliance
        /// </summary>
        public int TotalScore { get; set; }

        /// <summary>
        /// Ties to the Match data
        /// </summary>
        public Match Match { get; set; }

        /// <summary>
        /// Performance Pertaining to the Driver and driver station one
        /// </summary>
        public Performance RobotPerformanceOne { get; set; }

        /// <summary>
        /// Performance Pertaining to the Driver and driver station two
        /// </summary>
        public Performance RobotPerformanceTwo { get; set; }

        /// <summary>
        /// Performance Pertaining to the Driver and driver station three
        /// </summary>
        public Performance RobotPerformanceThree { get; set; }
    }

    /// <summary>
    /// The color of the Alliance
    /// </summary>
    public enum AllianceColor
    {
        Red, Blue
    }
}
