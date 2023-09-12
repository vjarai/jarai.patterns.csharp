namespace Jarai.Patterns.Behavioral.Visitor
{
    /// <summary>
    ///     The 'ConcreteElement' class
    /// </summary>
    public interface IVisitable
    {
        void Accept(Visitor visitor);
    }
}