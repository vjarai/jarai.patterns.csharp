using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Jarai.Patterns.Behavioral.Mediator
{
    public class Message
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return ($"{From} to {To}: {Text}.");
        }
    }
}