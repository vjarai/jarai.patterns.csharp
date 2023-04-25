using System.Diagnostics;

namespace Jarai.Refactoring.State.Refactored
{
    public class Aufgelegt : TelefonZustand
    {
        public Aufgelegt()
            : base("<H�rer ist aufgelegt>")
        {
        }

        public override TelefonZustand Abheben()
        {
            Debug.WriteLine("H�rer wird abgehoben.");
            return new Abgehoben();
        }

        public override TelefonZustand AnnehmenAnruf()
        {
            Debug.WriteLine("Anruf wird angenommen.");
            return new Verbunden();
        }
    }
}