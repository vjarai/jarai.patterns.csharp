using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Behavioral.Observer
{
    public class AktienkursChangedEventargs
    {
        public Aktie Aktie { get; set; }

        public double NeuerKurs { get; set; }
    }
}