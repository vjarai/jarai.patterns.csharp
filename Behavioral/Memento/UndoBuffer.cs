using System.Collections.Generic;

namespace Jarai.Patterns.Behavioral.Memento
{
    public class UndoBuffer
    {
        private readonly List<Memento> _mementos = new List<Memento>();

        private readonly Document _document;

        public UndoBuffer(Document document)
        {
            _document = document;
        }

        public void SaveDocument()
        {
            _mementos.Add(_document.CreateMemento());
        }

        public void RestoreDocument(int i)
        {
            _document.RestoreMemento(_mementos[i]);
        }

    }
}