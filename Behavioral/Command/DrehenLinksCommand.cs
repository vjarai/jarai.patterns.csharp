using System;

namespace Jarai.Patterns.Behavioral.Command
{
    public class DrehenLinksCommand : RobotCommand
    {
        private readonly int _grad;

        public DrehenLinksCommand(int grad)
        {
            _grad = grad;
        }

        public override void Execute(Roboter roboter)
        {
            roboter.DreheLinks(_grad);
        }

        public override void Undo(Roboter roboter)
        {
            roboter.DreheRechts(_grad);
        }
    }
}