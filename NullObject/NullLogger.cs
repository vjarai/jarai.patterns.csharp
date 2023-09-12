using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
    public class NullLogger : Logger
    {
        public override void Write(string text)
        {
            // No operation
        }
    }
}