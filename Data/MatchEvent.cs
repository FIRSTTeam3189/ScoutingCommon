using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    /// <summary>
    /// What went on during the match
    /// -GeoEngel
    /// </summary>
    public class MatchEvent
    {
        /// <summary>
        /// The performance where the event took place
        /// </summary>
        public Performance Performance { get; set; }

        /// <summary>
        /// What action the robot took
        /// </summary>
        public MatchEventType EventType { get; set; }

        /// <summary>
        /// The period where the event took place
        /// </summary>
        public MatchPeriod Period { get; set; }

        /// <summary>
        /// The Match Event's unique identifer
        /// </summary>
        public string Id { get; set; }
    }

    /// <summary>
    /// The Periods of the match
    /// </summary>
    public enum MatchPeriod
    {
        Autonomous, TeleOp, Final
    }
    
    /// <summary>
    /// The Possible actions a robot could do as a match event
    /// </summary>
    public enum MatchEventType
    {
        ReachDefense, CrossDefense1, CrossDefense2, CrossDefense3, CrossDefense4, CrossDefense5, MakeHighGoal, MakeLowGoal, MissHighGoal, MissLowGoal, FailedChallengeTower, ChallengeTower, FailedScaleTower, ScaleTower, Foul, TeachnicalFoul
    }
}
