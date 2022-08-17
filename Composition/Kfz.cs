using System;
using System.Diagnostics;

namespace Refresher.Aggregation
{
    public class Kfz
    {
        private readonly Rad[] _raeder;
        private int _baujahr;

        private Karosserie _karosserie;
        private double _tankinhalt;

        public Kfz(string marke, int leistung, string farbe)
        {
            Marke = marke;
            Motor = new Motor(leistung);
            _karosserie = new Karosserie(farbe);

            _raeder = new Rad[4];

            for (var i = 0; i < 4; i++) _raeder[i] = new Rad(60);
        }

        public Karosserie Karosserie
        {
            get { return _karosserie; }
        }

        public string Marke { get; }

        public Motor Motor { get; }

        public void Anlassen()
        {
            Motor.Anlassen();
        }

        public void Anzeigen()
        {
            _baujahr = DateTime.Now.Year;
            _tankinhalt = 5;

            Console.WriteLine("Marke     : {0}", Marke);
            Console.WriteLine("Baujahr   : {0}", _baujahr);
            Console.WriteLine("Tankinhalt: {0}", _tankinhalt);

            _karosserie.Anzeigen();
            Motor.Anzeigen();

            foreach (var rad in _raeder)
                rad.Anzeigen();
        }

        public void Fahren()
        {
            // Defensives Programmieren für die Kundenversion
            if (!Motor.IstAngelassen)
                Motor.Anlassen();

            // Offensives Programmieren während der Entwicklung
            Debug.Assert(Motor.IstAngelassen, "Motor ist aus!");

            if (!Motor.IstAngelassen)
                throw new InvalidOperationException("Motor ist aus!");


            if (_tankinhalt == 0)
                throw new InvalidOperationException("Tank ist leer!");


            Console.WriteLine(" Kfz fährt!");
        }
    }
}