using System;

namespace Decorator.RealWorld
{
    /// <summary>
    ///     Decorator Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            var video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display

            Console.WriteLine("\nMaking video borrowable:");

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            // Wait for user

            Console.ReadKey();
        }
    }
}