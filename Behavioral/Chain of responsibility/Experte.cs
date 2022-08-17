using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class Experte
    {
        /// <summary>
        ///     An den befreundeten Experten wird die Frage weitergeleitet,
        ///     wenn dieser Experte die Antwort nicht kennt
        /// </summary>
        private readonly Experte _befreundeterExperte;

        /// <summary>
        ///     Das Gehirn des Experten mit den Fragen und der jeweiligen Antwort
        /// </summary>
        private readonly Dictionary<string, string> _brain = new Dictionary<string, string>();

        /// <summary>
        ///     Name des Experten
        /// </summary>
        private readonly string _name;

        public Experte(string name, Experte befreundeterExperte = null)
        {
            _name = name;
            _befreundeterExperte = befreundeterExperte;
        }

        public string BeantworteFrage(string frage)
        {
            if (_brain.ContainsKey(frage))
                return $"{_name} sagt: {_brain[frage]}";

            if (_befreundeterExperte == null)
                throw new Exception($"Kein Experte kennt die Antwort für: '{frage}'.");

            Console.WriteLine($"{_name}: Das weiß ich leider nicht, ich frage mal {_befreundeterExperte._name}...");

            return _befreundeterExperte.BeantworteFrage(frage);
        }

        public void LerneAntwort(string frage, string antwort)
        {
            _brain.Add(frage, antwort);
        }
    }
}