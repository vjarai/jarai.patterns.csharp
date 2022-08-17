using System;

namespace Jarai.Patterns.Behavioral.Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var project = new Project();

            project.AddSymbol(new Symbol(100.00));
            project.AddSymbol(new Symbol(200.00));
            project.AddSymbol(new Symbol(300.00));
            project.AddSymbol(new Symbol(400.00));
            project.AddSymbol(new Symbol(500.00));

            var sb = new SummenBesucher();

            project.EmpfangeBesucher(sb);

            Console.WriteLine("Summe = {0:0.00} Euro", sb.Summe);

            var mb = new MaxBesucher();

            project.EmpfangeBesucher(mb);

            Console.WriteLine("Max   = {0:0.00} Euro", mb.Max);

            Console.Read();
        }
    }
}