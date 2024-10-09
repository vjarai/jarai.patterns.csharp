using System;

namespace Jarai.Patterns.Behavioral.Command
{
    public class Roboter
    {
        public void DreheLinks(int grad)
        {
            Console.WriteLine($"Roboter dreht {grad} grad links ");
        }

        public void DreheRechts(int grad)
        {
            Console.WriteLine($"Roboter dreht {grad} grad nach rechts");
        }

        public void HebeArm(int cm)
        {
            Console.WriteLine($"Roboter hebt Arm um {cm}");
        }

        public void SenkeArm(int cm)
        {
            Console.WriteLine($"Roboter senkt Arm um {cm}");
        }
    }
}