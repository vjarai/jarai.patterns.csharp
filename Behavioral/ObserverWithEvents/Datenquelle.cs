using System;

namespace Jarai.Patterns.Behavioral.ObserverWithEvents
{
    public class Datenquelle
    {
        private string _name;
        private int _wert;

        public Datenquelle(string name)
        {
            _name = name;
        }

        public int Wert
        {
            get { return _wert; }

            set
            {
                if (_wert != value)
                {
                    _wert = value;
                    OnWertChanged();
                }
            }
        }

        public event EventHandler<DatenquelleEventArg> WertChanged;

        private void OnWertChanged()
        {
            WertChanged?.Invoke(this, new DatenquelleEventArg(_wert));
        }
    }
}