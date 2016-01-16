using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    /// <summary>
    /// A picture type is a picture for the robot configuration 
    /// -GeoEngel
    /// </summary>
    public class Picture
    {
        /// <summary>
        /// ID string is a unique identification for each individual picture
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Location on the web of the picture (URL)
        /// </summary>
        public string PictureLocation { get; set; }

        /// <summary>
        /// Place for people to make notes about picture taken
        /// </summary>
        public ICollection<string> Comments { get; set; } 
    }
}
