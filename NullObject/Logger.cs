using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
