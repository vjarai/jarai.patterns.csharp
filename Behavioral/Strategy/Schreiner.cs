using System;

namespace Jarai.Patterns.Behavioral.Strategy
{
    public class Schreiner : Arbeiter
    {
        public Schreiner(string name) : base(name)
        {
        }

        public override void Arbeiten()
        {
            Console.WriteLine("- Schrank produziert durch '{0}'", Name);
        }
    }
}