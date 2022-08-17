namespace Jarai.Patterns.Behavioral.Visitor
{
    public class Symbol
    {
        public Symbol(double preis)
        {
            Preis = preis;
        }

        public double Preis { get; }

        public void EmpfangeBesucher(Besucher b)
        {
            b.Besuche(this);
        }
    }
}