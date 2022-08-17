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
            Console.WriteLine("Undo Drehe rechts " + _grad + " Grad");
        }

        public override void Undo(Roboter roboter)
        {
            Console.WriteLine("Drehe rechts " + _grad + " Grad");
        }
    }
}