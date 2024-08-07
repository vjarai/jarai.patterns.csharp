using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Structural.Flyweigth
{
    public class FlyweightText
    {
        public string Text { get; set; }

        public Format  Format { get; set; }

        public override string ToString()
        {
            return $"{Text} {Format}";
        }
    }
}