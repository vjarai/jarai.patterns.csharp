

using System;

namespace Jarai.Patterns.Structural.Facade
{
    public class TheaterLights
    {
        String _description;

        public TheaterLights(String description)
        {
            this._description = description;
        }

        public void On()
        {
            Console.WriteLine(_description + " on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " off");
        }

        public void Dim(int level)
        {
            Console.WriteLine(_description + " dimming to " + level + "%");
        }

        public override String ToString()
        {
            return _description;
        }
    }
}