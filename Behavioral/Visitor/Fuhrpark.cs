using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Visitor
{
    /// <summary>
    ///     The 'ObjectStructure' class
    /// </summary>
    public class Fuhrpark
    {
        private readonly List<IVisitable> _fahrzeuge = new List<IVisitable>();

        public void AcceptVisitor(Visitor visitor)
        {
            foreach (var fahrzeug in _fahrzeuge)
            {
                fahrzeug.Accept(visitor);
            }

            Console.WriteLine();
        }

        public void Add(IVisitable fahrzeug)
        {
            _fahrzeuge.Add(fahrzeug);
        }

        
    }
}