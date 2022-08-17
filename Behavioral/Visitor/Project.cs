using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Visitor
{
    public class Project
    {
        private readonly List<Symbol> _symols = new List<Symbol>();

        public void AddSymbol(Symbol sym)
        {
            _symols.Add(sym);
        }

        public void EmpfangeBesucher(Besucher besucher)
        {
            foreach (var sym in _symols) besucher.Besuche(sym);
        }
    }
}