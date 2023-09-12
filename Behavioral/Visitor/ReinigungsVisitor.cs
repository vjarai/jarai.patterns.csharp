using System;

namespace Jarai.Patterns.Behavioral.Visitor
{
    public class ReinigungsVisitor : Visitor
    {
        public override void Visit(Bus bus)
        {
            Console.WriteLine("Reinigungskraft staubsaugt den Bus.");
        }

        public override void Visit(Lkw lkw)
        {
            Console.WriteLine("Reinigungskraft dampfstrahlt den Lkw.");
        }
    }
}