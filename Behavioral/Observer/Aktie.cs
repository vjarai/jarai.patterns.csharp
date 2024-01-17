using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Observer
{
    public class Aktie 
    {
        private int _kurs;

        public int Kurs
        {
            get { return _kurs; }
            set
            {
                _kurs = value;
                UpdateBeobachter();
            }
        }


        private void UpdateBeobachter()
        {
            var message = new AktienkursChangedEventargs { Aktie = this, NeuerKurs = _kurs };

            foreach (var b in _beobachter)
                b.Update(this, message);
        }


        private readonly List<Beobachter> _beobachter = new List<Beobachter>();

        public void AddBeobachter(Beobachter beobachter)
        {
            _beobachter.Add(beobachter);
        }

        public void RemoveBeobachter(Beobachter beobachter)
        {
            _beobachter.Remove(beobachter);
        }

    }
}