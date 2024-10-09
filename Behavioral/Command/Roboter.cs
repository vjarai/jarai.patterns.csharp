using System;

namespace Jarai.Patterns.Behavioral.Command
{
    public class Roboter
    {
        public void DreheLinks()
        {
            Console.WriteLine("Roboter dreht nach links");
        }

        public void DreheRechts()
        {
            Console.WriteLine("Roboter dreht nach rechts");
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