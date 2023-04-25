using System;

namespace Jarai.Refactoring.State.Refactored
{
    public abstract class TelefonZustand
    {
        protected TelefonZustand(string bezeichnung)
        {
            Bezeichnung = bezeichnung;
        }

        public string Bezeichnung { get; }

        public virtual TelefonZustand Abheben()
        {
            throw new InvalidOperationException("Sie k�nnen derzeit den H�rer nicht abheben.");
        }

        public virtual TelefonZustand AnnehmenAnruf()
        {
            throw new InvalidOperationException("Sie k�nnen derzeit keinen Anruf annehmen.");
        }

        public virtual TelefonZustand Auflegen()
        {
            throw new InvalidOperationException("Sie k�nnen derzeit den H�rer nicht auflegen.");
        }

        public virtual TelefonZustand Sprechen()
        {
            throw new InvalidOperationException("Sie k�nnen derzeit nicht sprechen.");
        }


        public override string ToString()
        {
            return Bezeichnung;
        }

        public virtual TelefonZustand W�hlen()
        {
            throw new InvalidOperationException("Sie k�nnen derzeit keine Nummer w�hlen.");
        }
    }
}