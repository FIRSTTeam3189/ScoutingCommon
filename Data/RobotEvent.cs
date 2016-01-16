using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutingModels.Data
{
    public class RobotEvent
    {

    }

    public enum RobotEventType
    {
        ReachDefense, CrossDefense1, CrossDefense2, CrossDefense3, CrossDefense4, CrossDefense5, MakeHighGoal, MakeLowGoal, MissHighGoal, MissLowGoal, FailedChallengeTower, ChallengeTower, FailedScaleTower, ScaleTower, Foul, TeachnicalFoul
    }
}
