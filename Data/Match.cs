using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{

    /// <summary>
    /// Tells the Information on a match
    /// -GeoEngel
    /// </summary>
    public class Match
    {
        /// <summary>
        /// Labels the Match in accordance to rank
        /// </summary>
        public MatchType Type { get; set; }

        /// <summary>
        /// Ties the Match to the Event
        /// </summary>
        public Event Event { get; set; }

        /// <summary>
        /// Gives the Match a Unique Identification
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Retreives the Team's Number
        /// </summary>
        public int TeamNumber { get; set; }

        /// <summary>
        /// Ties to the Teams on the Red alliance
        /// </summary>
        public Alliance RedAlliance { get; set; }

        /// <summary>
        /// Ties to the Teams on the Blue alliance
        /// </summary>
        public Alliance BlueAlliance { get; set; }
    }

    /// <summary>
    /// Match Types 
    /// </summary>
    public enum MatchType
    {
        Practice, Qualification, PlayOffs
    }
}
