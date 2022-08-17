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
            Console.WriteLine("Drehe links " + _grad + " Grad");
        }

        public override void Undo(Roboter roboter)
        {
            Console.WriteLine("Rückgängog Drehe links " + _grad + " Grad");
        }
    }
}