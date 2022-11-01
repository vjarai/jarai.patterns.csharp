using System;

namespace Jarai.Patterns.Behavioral.Mediator
{
    /// <summary>
    /// Mediator Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create tower

            var tower = new Tower("Tower");

            Plane airliner = new Airliner("Airliner");
            Plane helicopter = new Helicopter("Helicopter");
            Plane sailplane = new Sailplane("Sailplane");

            airliner.Connect(tower);
            helicopter.Connect(tower);
            sailplane.Connect(tower);

            helicopter.Send("Request Landing");
            tower.Send(helicopter.Name, "Cleared to Land");
            helicopter.Send("Roger, Cleared to Land");
            helicopter.Send("Runway vacated.");

            airliner.Send("Ready for departure");
            tower.Send(airliner.Name, "Cleared for takeoff");
            airliner.Send("Roger, Cleared for takeoff");
            airliner.Send("Request Leaving frequency");
            tower.Send(airliner.Name, "Roger, Frequency change approved");

            Console.ReadKey();
        }
    }
}
