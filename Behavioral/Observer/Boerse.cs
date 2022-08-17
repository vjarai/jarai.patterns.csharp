using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Observer
{
    public class Boerse : IBeobachtbar
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
            foreach (var b in _beobachter)
                b.Update(this, _kurs);
        }

        #region IBeobachtbar Member

        private readonly List<IBeobachter> _beobachter = new List<IBeobachter>();

        public void AddBeobachter(IBeobachter beobachter)
        {
            _beobachter.Add(beobachter);
        }

        public void RemoveBeobachter(IBeobachter beobachter)
        {
            _beobachter.Remove(beobachter);
        }

        #endregion
    }
}