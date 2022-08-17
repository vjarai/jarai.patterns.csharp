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
            Console.WriteLine("Senke " + _cm + " cm");
        }

        public override void Undo(Roboter roboter)
        {
            Console.WriteLine("Undo Senke " + _cm + " cm");
        }
    }
}