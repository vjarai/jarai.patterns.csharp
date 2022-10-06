using System;

namespace Jarai.Patterns.Behavioral.Visitor
{
    /// <summary>
    ///     A 'ConcreteVisitor' class
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = (Employee)element;

            // Provide 3 extra vacation days

            employee.VacationDays += 3;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}");
        }
    }
}