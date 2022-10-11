using System;

namespace Decorator.RealWorld
{
    /// <summary>
    ///     The 'ConcreteComponent' class
    /// </summary>
    public class Video : LibraryItem
    {
        private readonly string director;
        private readonly int playTime;
        private readonly string title;

        // Constructor

        public Video(string director, string title, int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            NumCopies = numCopies;
            this.playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", director);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", playTime);
        }
    }
}