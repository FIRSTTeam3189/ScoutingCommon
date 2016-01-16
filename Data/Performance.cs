using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    /// <summary>
    /// How the Team did that match
    /// -GeoEngel
    /// </summary>
    public class Performance
    {
        /// <summary>
        /// Ties the Performance to a match
        /// </summary>
        public Match Match { get; set; }

        /// <summary>
        /// Ties the Performance to a Team
        /// </summary>
        public Team Team { get; set; }

        /// <summary>
        /// Gives the performance a unique ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A collection of Events
        /// </summary>
        public ICollection<MatchEvent> Events { get; set; }
    }
}
