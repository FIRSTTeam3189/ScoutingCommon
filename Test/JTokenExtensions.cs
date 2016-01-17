using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using ScoutingModels.Data;

namespace ScoutingModels.Test
{
    public static class JTokenExtensions
    {
        private const string EventLocation = "location";
        private const string EventType = "event_type";
        private const string EventCode = "event_code";
        private const string EventYear = "year";
        private const string EventWebsite = "website";

        /// <summary>
        /// Gets an Event from the JToken provided
        /// </summary>
        /// <param name="obj">Object to get it from</param>
        /// <returns>The Event</returns>
        public static Event GetEventFromJToken(this JToken obj)
        {
            obj.IsNotNull();

            var ev = new Event
            {
                Location = obj[EventLocation].ToObject<string>(),
                Year = obj[EventYear].ToObject<int>(),
                EventCode = obj[EventCode].ToObject<string>(),
                Type = (EventType) obj[EventType].ToObject<int>(),
                Website = obj[EventWebsite].ToObject<string>() ?? "No EventWebsite",
                Id = Guid.NewGuid().ToString()
            };

            return ev;
        }
    }
}
