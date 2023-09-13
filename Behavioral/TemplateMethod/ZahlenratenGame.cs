using System;

namespace Jarai.Patterns.Behavioral.TemplateMethod
{
    public class ZahlenratenGame : Game
    {
        private int _geheimzahl;
        private int _input;

        protected override bool IsFinished()
        {
            return _input == _geheimzahl;
        }

        protected override void EndGame()
        {
            Console.WriteLine("Spiel beendet");
        }

        protected override void ShowOutput()
        {
            if (_input < _geheimzahl)
                Console.WriteLine("zu klein");
            else if (_input > _geheimzahl)
                Console.WriteLine("Zu Gross");
        }

        protected override void GetInput()
        {
            Console.WriteLine(("tipp eingeben"));
            _input = Convert.ToInt32(Console.ReadLine());
        }

        protected override void InitGame()
        {
            _geheimzahl = (new Random().Next(1, 101));
        }
    }
}