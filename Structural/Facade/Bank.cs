using System;

namespace Jarai.Patterns.Structural.Facade
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>

    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}