using System.Collections;

namespace Jarai.Patterns.Behavioral.Iterator
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate for the implementing
        // object.
        public abstract IEnumerator GetEnumerator();
    }
}