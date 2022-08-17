using System.Collections;

namespace Jarai.Patterns.Behavioral.Iterator
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current
        {
            get { return Current(); }
        }

        // Returns the current element
        public abstract object Current();

        // Returns the key of the current element
        public abstract int Key();

        // Move forward to next element
        public abstract bool MoveNext();

        // Rewinds the Iterator to the first element
        public abstract void Reset();
    }
}