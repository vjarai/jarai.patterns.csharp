using System;

namespace Jarai.Patterns.Behavioral.Command
{
    public class SenkenCommand : RobotCommand
    {
        private readonly int _cm;

        public SenkenCommand(int cm)
        {
            _cm = cm;
        }

        public override void Execute(Roboter roboter)
        {
            roboter.SenkeArm(_cm);
        }

        public override void Undo(Roboter roboter)
        {
           roboter.HebeArm(_cm);
        }
    }
}