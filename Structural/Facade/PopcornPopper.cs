using System;

namespace Jarai.Patterns.Structural.Facade
{
    public class PopcornPopper
    {
        String _description;

        public PopcornPopper(String description)
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

        public void Pop()
        {
            Console.WriteLine(_description + " popping popcorn!");
        }


        public override String ToString()
        {
            return _description;
        }
    }
}