using System;

namespace Jarai.Patterns.Behavioral.Observer
{
    public class Person : IBeobachter
    {
        #region IBeobachter Member

        public void Update(object sender, int kurs)
        {
            Console.WriteLine("PERSON: Börsenkurs hat sich geändert auf {0}.", kurs);
        }

        #endregion
    }
}