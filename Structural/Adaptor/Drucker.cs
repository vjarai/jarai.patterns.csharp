using System;

namespace Jarai.Patterns.Structural.Adapter
{
    public class Drucker
    {
        public virtual void Drucken(string text)
        {
            Console.WriteLine("DRUCKEN: {0}", text);
        }
    }
}