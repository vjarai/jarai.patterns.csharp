using System;

namespace Jarai.Patterns.Structural.Bridge
{
    /// <summary>
    ///     Bridge Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create RefinedAbstraction
            var customers = new Customers
            {
                // Set ConcreteImplementor
                Data = new CustomersData("Chicago")
            };


            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}