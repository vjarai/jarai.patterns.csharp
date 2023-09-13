namespace Jarai.Patterns.Behavioral.Visitor
{
    public class Lkw : IVisitable
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}