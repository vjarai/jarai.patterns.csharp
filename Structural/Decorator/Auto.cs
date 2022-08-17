using System;

namespace Jarai.Patterns.Structural.Decorator
{
    public class Auto
    {
        private int _kmstand;

        public virtual void Fahren(int strecke)
        {
            _kmstand += strecke;
        }

        public virtual void StreckeAusgeben()
        {
            Console.WriteLine("Auto hat {0} km auf dem Buckel.", _kmstand);
        }
    }
}