using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    /// <summary>
    /// Summery of a Team's Robot
    /// </summary>
    public class Robot
    {
        /// <summary>
        /// The robot's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Robot's unique ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The Robot's Team
        /// </summary>
        public Team Owner { get; set; }

        /// <summary>
        /// A Collection of the Robot's Performances
        /// </summary>
        public ICollection<Performance> RobotPerformances { get; set; } 
    }
}
