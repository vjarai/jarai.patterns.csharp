using System;

namespace Jarai.Patterns.Behavioral.Command
{
    public class DrehenRechtsCommand : RobotCommand
    {
        private readonly int _grad;

        public DrehenRechtsCommand(int grad)
        {
            _grad = grad;
        }

        public override void Execute(Roboter roboter)
        {
            roboter.DreheRechts();
        }

        public override void Undo(Roboter roboter)
        {
            roboter.DreheLinks();
        }
    }
}