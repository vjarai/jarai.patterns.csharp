using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Structural.Bridge
{
    /// <summary>
    ///     The 'ConcreteImplementor' class
    /// </summary>
    public class CustomersData : DataObject
    {
        private readonly string _city;
        private readonly List<string> _customers = new List<string>();
        private int _current;

        public CustomersData(string city)
        {
            _city = city;
            // Loaded from a database 
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lisa Giolani");
        }

        public override void AddRecord(string customer)
        {
            _customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }

        public override string GetCurrentRecord()
        {
            return _customers[_current];
        }

        public override void NextRecord()
        {
            if (_current <= _customers.Count - 1) _current++;
        }

        public override void PriorRecord()
        {
            if (_current > 0) _current--;
        }

        public override void ShowAllRecords()
        {
            Console.WriteLine("Customer City: " + _city);
            foreach (var customer in _customers) Console.WriteLine(" " + customer);
        }

        public override void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }
    }
}