namespace Jarai.Patterns.Behavioral.Memento
{
    public class Memento
    {
        public string Text { get; }

        public Memento(string text)
        {
            this.Text = text;
        }
    }
}