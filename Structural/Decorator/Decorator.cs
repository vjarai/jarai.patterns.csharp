namespace Decorator.RealWorld
{
    /// <summary>
    ///     The 'Decorator' abstract class
    /// </summary>
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem LibraryItem;

        // Constructor

        public Decorator(LibraryItem libraryItem)
        {
            this.LibraryItem = libraryItem;
        }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}