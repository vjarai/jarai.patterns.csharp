using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Behavioral.Visitor
{
    public abstract class Visitor
    {
        public abstract void Visit(Bus bus);
        public abstract void Visit(Lkw lkw);
    }
}