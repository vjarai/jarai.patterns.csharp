using System;

namespace Jarai.Patterns.Behavioral.Visitor
{
    /// <summary>
    ///     Visitor Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup employee collection

            var employee = new Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());

            // Employees are 'visited'

            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());

            // Wait for user

            Console.ReadKey();
        }
    }
}