﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    public class Team
    {
        public string NickName { get; set; }
        public int Number { get; set; }
        public string RookieYear { get; set; }
        public Alliance RedAlliance { get; set; }
        public Alliance BlueAlliance { get; set; }
    }
}
