using System;

namespace Jarai.Patterns.Behavioral.Observer
{
    public class Beobachter 
    {
        public void Update(object sender, AktienkursChangedEventargs message)
        {
            Console.WriteLine("Beobachter: Börsenkurs hat sich geändert auf {0}.", message.NeuerKurs);
        }

    }
}