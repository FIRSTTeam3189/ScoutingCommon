using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    /// <summary>
    /// Includes all of the information about an event
    /// -GeoEngel
    /// </summary>
    public class Event
    {
        /// <summary>
        /// classifies the Event in terms of Ranking
        /// </summary>
        public EventType Type { get; set; }

        /// <summary>
        /// Holds the adress of the Event's location
        /// </summary>
        public string Location { get; set; }
        
        /// <summary>
        /// Gives each Event A unique ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Holds the Date the Event is held on
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Unique Identifier for the event used in Blue Alliance
        /// </summary>
        public string EventCode { get; set; }
        
        /// <summary>
        /// The Event's Webpage if available
        /// </summary>
        public string Website { get; set; }
    }

    /// <summary>
    /// Event Types
    /// </summary>
    public enum EventType : int
        {
               Preseason = 100,
               District = 1,
               DistrictChampionship = 2,
               Regional = 0,
               ChampionshipDivison = 3,
               Championship = 4,
               OffSeason = 99,
               Unlabeled = -1
        }
}
