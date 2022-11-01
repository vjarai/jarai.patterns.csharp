using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Interpreter
{
    /// <summary>
    /// Interpreter Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            var roman = "MCMXXVIII";
            var context = new Context(roman);

            // Build the 'parse tree'

            var tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
                roman, context.Output);

            // Wait for user

            Console.ReadKey();
        }
    }
}
