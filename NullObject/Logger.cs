using System.Diagnostics;

namespace NullObject
{
    public class Logger
    {
        public virtual void Write(string text)
        {
            Debug.WriteLine(text);
        }
    }
}
