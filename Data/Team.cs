using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{

    /// <summary>
    /// The Team that a robot belongs to etc.
    /// -GeoEngel
    /// </summary>
    public class Team
    {
        /// <summary>
        /// The Teams NickName
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// The Teams offical Number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// The year the team was a rookie
        /// </summary>
        public string RookieYear { get; set; }

        /// <summary>
        /// What events have they attended
        /// </summary>
        public ICollection<Event> EventsAttended { get; set; }

        /// <summary>
        /// What Robot the team has
        /// </summary>
        public Robot Robot { get; set; }
    }
}
