using System.Diagnostics;

namespace Jarai.Refactoring.State.Refactored
{
    public class Abgehoben : TelefonZustand
    {
        public Abgehoben()
            : base("<H�rer ist abgenommen>")
        {
        }

        public override TelefonZustand Auflegen()
        {
            Debug.WriteLine("H�rer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override TelefonZustand W�hlen()
        {
            Debug.WriteLine("Rufnummer wird gew�hlt.");
            return new Verbunden();
        }
    }
}