using System.Diagnostics;

namespace Jarai.Refactoring.State.Refactored
{
    public class Verbunden : TelefonZustand
    {
        public Verbunden()
            : base("<Verbindung ist hergestellt>")
        {
        }

        public override TelefonZustand Auflegen()
        {
            Debug.WriteLine("Hörer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override TelefonZustand Sprechen()
        {
            Debug.WriteLine("Es wird gesprochen.");
            return this;
        }
    }
}