using System;

namespace Jarai.Patterns.Behavioral.Visitor
{
    /// <summary>
    ///     A 'ConcreteVisitor' class
    /// </summary>
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = (Employee)element;

            // Provide 10% pay raise

            employee.Income *= 1.10;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income:C}");
        }
    }
}