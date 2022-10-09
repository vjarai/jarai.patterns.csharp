namespace Jarai.Patterns.Structural.Flyweigth
{
    /// <summary>
    ///     The 'Flyweight' abstract class
    /// </summary>
    public abstract class Character
    {
        protected int ascent;
        protected int descent;
        protected int height;
        protected int pointSize;
        protected char symbol;
        protected int width;

        public abstract void Display(int pointSize);
    }
}