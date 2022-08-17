namespace Jarai.Patterns.Behavioral.Visitor
{
    public class SummenBesucher : Besucher
    {
        public double Summe { get; private set; }

        public override void Besuche(Symbol sym)
        {
            Summe += sym.Preis;
        }
    }
}