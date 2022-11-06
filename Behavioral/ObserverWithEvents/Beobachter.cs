using System;

namespace Jarai.Patterns.Behavioral.ObserverWithEvents
{
    public class Beobachter
    {
        private readonly string _name;

        public Beobachter(string name)
        {
            _name = name;
        }

        public void WertPerMail(object sender, DatenquelleEventArg e)
        {
            Console.WriteLine("{0} hat Wert ({1}) als Mail empfangen.", _name, e.Wert);
        }

        public void WertPerSms(object sender, DatenquelleEventArg e)
        {
            Console.WriteLine("{0} hat Wert ({1}) als SMS empfangen.", _name, e.Wert);
        }
    }
}