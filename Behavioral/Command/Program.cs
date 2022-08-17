using System;

namespace Jarai.Patterns.Behavioral.Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var roboter = new Roboter();

            var macroCommand = new MacroCommand(new RobotCommand[]
            {
                new HebenCommand(10),
                new DrehenLinksCommand(45)
            });

            macroCommand.Execute(roboter);
            macroCommand.Undo(roboter);

            Console.ReadLine();
        }
    }
}