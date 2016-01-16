using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    public class Robot
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Team Owner { get; set; }
    }
}
