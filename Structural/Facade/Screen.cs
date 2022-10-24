using System;

namespace Jarai.Patterns.Structural.Facade
{
    public class Screen
    {
        String _description;

        public Screen(String description)
        {
            this._description = description;
        }

        public void Up()
        {
            Console.WriteLine(_description + " going up");
        }

        public void Down()
        {
            Console.WriteLine(_description + " going down");
        }


        public override String ToString()
        {
            return _description;
        }
    }
}
