namespace Jarai.Patterns.Behavioral.Command
{
    public class HebenCommand : RobotCommand
    {
        private readonly int _cm;

        public HebenCommand(int cm)
        {
            _cm = cm;
        }

        public override void Execute(Roboter roboter)
        {
            roboter.HebeArm(_cm);
        }

        public override void Undo(Roboter roboter)
        {
            roboter.SenkeArm(_cm);
        }
    }
}