using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Behavioral.Visitor
{
    public class Bus : IVisitable
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}