using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    public class Event
    {
        public string Location { get; set; }
        public string Id { get; set; }
        public string Date { get; set; }
        public string EventCose { get; set; }
        public string Website { get; set; }
    }

    public enum EventType
        {
               Practice, Qualification, PlayOffs
        }
}
