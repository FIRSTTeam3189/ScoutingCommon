using System;
using System.Collections.Generic;
using System.Globalization;
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
        private const string StartDate = "start_date";
        private const string EndDate = "end_date";
        private const string DateFormat = "yyyy-MM-dd";

        /// <summary>
        /// Gets an Event from the JToken provided
        /// </summary>
        /// <param name="obj">Object to get it from</param>
        /// <returns>The Event</returns>
        public static Event GetEventFromJToken(this JToken obj)
        {
            obj.IsNotNull();

            DateTime? start = null;
            DateTime? end = null;
            DateTime t;

            // Get the DateTimes for start, end
            if (DateTime.TryParseExact(obj[StartDate].ToObject<string>(), DateFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.AdjustToUniversal,
                out t))
                start = DateTime.ParseExact(obj[StartDate].ToObject<string>(), DateFormat,
                    CultureInfo.InvariantCulture);

            if (DateTime.TryParseExact(obj[EndDate].ToObject<string>(), DateFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.AdjustToUniversal,
                out t))
                end = DateTime.ParseExact(obj[EndDate].ToObject<string>(), DateFormat,
                    CultureInfo.InvariantCulture);

            var ev = new Event
            {
                Location = obj[EventLocation].ToObject<string>(),
                Year = obj[EventYear].ToObject<int>(),
                EventCode = obj[EventCode].ToObject<string>(),
                Type = (EventType) obj[EventType].ToObject<int>(),
                Website = obj[EventWebsite].ToObject<string>() ?? "No EventWebsite",
                Id = Guid.NewGuid().ToString(),
                StartDate = start,
                EndDate = end,
                Name = obj["name"].ToObject<string>()
            };

            return ev;
        }

        /// <summary>
        /// Gets a Team's Information from JToken provided
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Team GetTeamFromJToken(this JToken obj)
        {
            obj.IsNotNull();

            var te = new Team
            {
                Number = obj["team_number"].ToObject<int>(),
                NickName = obj["nickname"].ToObject<string>(),
                RookieYear = obj["rookie_year"].ToObject<int?>() ?? -1,
                Robot = new Robot(),
                EventsAttended = new List<Event>()
            };

            return te;
        }

    }
}
