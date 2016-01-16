using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace ScoutingModels.Data
{
    public class Match
    {
        public string Id { get; set; }
        public int TeamNumber { get; set; }
        public string Type { get; set; }
        public Alliance RedAlliance { get; set; }
        public Alliance BlueAlliance { get; set; }
    }
}
