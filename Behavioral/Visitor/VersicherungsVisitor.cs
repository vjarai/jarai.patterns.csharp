using System;

namespace Jarai.Patterns.Behavioral.Visitor
{
    public class VersicherungsVisitor : Visitor
    {
        public override void Visit(Bus bus)
        {
            Console.WriteLine("Versicherungsvertreter begutachtet den Bus.");
        }

        public override void Visit(Lkw lkw)
        {
            Console.WriteLine("Versicherungsvertreter begutachtet den Lkw.");
        }
    }
}