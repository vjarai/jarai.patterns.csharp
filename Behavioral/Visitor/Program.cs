namespace Jarai.Patterns.Behavioral.Visitor
{
    /// <summary>
    ///     Visitor Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var fuhrpark = new Fuhrpark();
            fuhrpark.Add(new Lkw());
            fuhrpark.Add(new Bus());

            fuhrpark.AcceptVisitor(new ReinigungsVisitor());
            fuhrpark.AcceptVisitor(new VersicherungsVisitor());
        }
    }
}