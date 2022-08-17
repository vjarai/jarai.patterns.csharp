using System;

namespace Jarai.Patterns.Behavioral.Observer
{
    public class Firma : IBeobachter
    {
        #region IBeobachter Member

        public void Update(object sender, int kurs)
        {
            Console.WriteLine("FIRMA: Börsenkurs hat sich geändert auf {0}.", kurs);
        }

        #endregion
    }
}