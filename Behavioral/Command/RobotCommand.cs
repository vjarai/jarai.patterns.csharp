namespace Jarai.Patterns.Behavioral.Command
{
    public abstract class RobotCommand
    {
        public abstract void Execute(Roboter roboter);

        public abstract void Undo(Roboter roboter);
    }
}