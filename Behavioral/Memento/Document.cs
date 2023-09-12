using System;

namespace Jarai.Patterns.Behavioral.Memento
{
    public class Document
    {
        string _text;

        public Memento CreateMemento()
        {
            return new Memento(_text);
        }

        // Restores memento

        public void RestoreMemento(Memento memento)
        {
            _text = memento.Text;
        }

        public void SetText(string neuerText)
        {
            _text = neuerText;
        }

        public void Show()
        {
            Console.WriteLine(_text);
        }
    }
}