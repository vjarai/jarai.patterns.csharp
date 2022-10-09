using System;

namespace Jarai.Patterns.Structural.Facade
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade

            var mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer

            var customer = new Customer("Ann McKinsey");
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    }
}
