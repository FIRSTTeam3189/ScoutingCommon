using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    /// <summary>
    /// Configures The Robot with unique ID and properties
    /// -GeoEngel
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Robot It Pertains To
        /// </summary>
        public Robot Robot { get; set; }

        /// <summary>
        /// Robot's unique ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Picture of the Robot
        /// </summary>
        public ICollection<Picture> Pictures { get; set; } 
    }
}
