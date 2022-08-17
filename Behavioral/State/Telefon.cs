using System;

namespace Jarai.Patterns.Behavioral.State
{
    public class Telefon
    {
        private Zustand _aKtuellerZustand;

        public Telefon()
        {
            AKtuellerZustand = new Aufgelegt();
        }

        public Zustand AKtuellerZustand
        {
            get { return _aKtuellerZustand; }
            private set
            {
                if (_aKtuellerZustand != value)
                {
                    _aKtuellerZustand = value;

                    OnZustandChange();
                }
            }
        }

        public void Abheben()
        {
            AKtuellerZustand = AKtuellerZustand.Abheben();
        }

        public void Annehmen()
        {
            AKtuellerZustand = AKtuellerZustand.Annehmen();
        }

        public void Auflegen()
        {
            AKtuellerZustand = AKtuellerZustand.Auflegen();
        }

        public void Sprechen()
        {
            AKtuellerZustand = AKtuellerZustand.Sprechen();
        }

        public void Wählen()
        {
            AKtuellerZustand = AKtuellerZustand.Wählen();
        }

        public event EventHandler AktuellerZustandChanged;

        private void OnZustandChange()
        {
            AktuellerZustandChanged?.Invoke(this, new EventArgs());
        }
    }
}