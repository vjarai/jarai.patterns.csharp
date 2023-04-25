using System.Diagnostics;

namespace Jarai.Refactoring.State.Refactored
{
    public class Abgehoben : TelefonZustand
    {
        public Abgehoben()
            : base("<Hörer ist abgenommen>")
        {
        }

        public override TelefonZustand Auflegen()
        {
            Debug.WriteLine("Hörer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override TelefonZustand Wählen()
        {
            Debug.WriteLine("Rufnummer wird gewählt.");
            return new Verbunden();
        }
    }
}