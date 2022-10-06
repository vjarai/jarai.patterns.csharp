using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Visitor
{
    /// <summary>
    ///     The 'ObjectStructure' class
    /// </summary>
    public class Employees
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in _employees)
            {
                employee.Accept(visitor);
            }

            Console.WriteLine();
        }

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }
    }
}