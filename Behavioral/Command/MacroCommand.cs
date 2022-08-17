using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Command
{
    public class MacroCommand : RobotCommand
    {
        private readonly List<RobotCommand> _childCommands = new List<RobotCommand>();


        public MacroCommand(IEnumerable<RobotCommand> childCommands)
        {
            _childCommands.AddRange(childCommands);
        }


        public override void Execute(Roboter r)
        {
            foreach (var command in _childCommands) command.Execute(r);
        }

        public override void Undo(Roboter r)
        {
            for (var i = _childCommands.Count - 1; i >= 0; i--) _childCommands[i].Undo(r);
        }
    }
}