using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ScoutingModels.Data
{
    public class Alliance
    {
        public enum Color { get; set; }
        public string Id { get; set; }
        public int TotalScore { get; set; }
        public Match Match { get; set; }
        public Team TeamOne { get; set; }
        public Team TeamTwo { get; set; }
        public Team TeamThree { get; set; }
    }

    public enum AllianceColor
    {
        Red, Blue
    }
}
