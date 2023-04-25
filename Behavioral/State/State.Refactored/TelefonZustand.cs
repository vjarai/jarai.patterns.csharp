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
            throw new InvalidOperationException("Sie können derzeit den Hörer nicht abheben.");
        }

        public virtual TelefonZustand AnnehmenAnruf()
        {
            throw new InvalidOperationException("Sie können derzeit keinen Anruf annehmen.");
        }

        public virtual TelefonZustand Auflegen()
        {
            throw new InvalidOperationException("Sie können derzeit den Hörer nicht auflegen.");
        }

        public virtual TelefonZustand Sprechen()
        {
            throw new InvalidOperationException("Sie können derzeit nicht sprechen.");
        }


        public override string ToString()
        {
            return Bezeichnung;
        }

        public virtual TelefonZustand Wählen()
        {
            throw new InvalidOperationException("Sie können derzeit keine Nummer wählen.");
        }
    }
}