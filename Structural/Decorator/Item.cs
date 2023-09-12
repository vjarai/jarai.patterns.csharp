namespace Jarai.Patterns.Structural.Decorator
{
    public abstract class Item
    {
        public abstract void Show();
        public int NumCopies { get; set; }
    }
}