using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class Person
    {
        /// <summary>
        ///     An die befreundete Person wird die Frage weitergeleitet,
        ///     wenn diese Person die Antwort nicht kennt
        /// </summary>
        private readonly Person _befreundetePerson;

        /// <summary>
        ///     Das "Gehirn" der Person mit den Fragen und der jeweiligen Antwort
        /// </summary>
        private readonly Dictionary<string, string> _brain = new Dictionary<string, string>();

        /// <summary>
        ///     Name der Person
        /// </summary>
        private readonly string _name;

        public Person(string name, Person befreundetePerson = null)
        {
            _name = name;
            _befreundetePerson = befreundetePerson;
        }

        public string BeantworteFrage(string frage)
        {
            if (_brain.ContainsKey(frage))
                return $"{_name} sagt: {_brain[frage]}";

            if (_befreundetePerson == null)
                throw new Exception($"Keine Person kennt die Antwort für: '{frage}'.");

            Console.WriteLine($"{_name}: Das weiß ich leider nicht, ich frage mal {_befreundetePerson._name}...");

            return _befreundetePerson.BeantworteFrage(frage);
        }

        public void LerneAntwort(string frage, string antwort)
        {
            _brain.Add(frage, antwort);
        }
    }
}