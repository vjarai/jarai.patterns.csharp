using System;

namespace Jarai.Patterns.Behavioral.ObserverWithEvents
{
    public class DatenquelleEventArg : EventArgs
    {
        public DatenquelleEventArg(int wert)
        {
            Wert = wert;
        }

        public int Wert { get; }
    }
}