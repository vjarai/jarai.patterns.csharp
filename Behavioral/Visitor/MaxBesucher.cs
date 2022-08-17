using System;

namespace Jarai.Patterns.Behavioral.Visitor
{
    public class MaxBesucher : Besucher
    {
        public double Max { get; private set; }

        public override void Besuche(Symbol sym)
        {
            Max = Math.Max(Max, sym.Preis);
        }
    }
}