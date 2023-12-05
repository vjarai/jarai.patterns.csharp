using System;

namespace Jarai.Patterns.Structural.Decorator
{
    /// <summary>
    ///     Decorator Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Book { Author = "Worley", Title = "Inside ASP.NET" };
            book.Show();

            var video = new Video { Director = "Spielberg", Title = "Jaws",  PlayTime = 92 };
            video.Show();

            // Make video borrowable at runtime, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            var borrowableVideo = new BorrowableItemDecorator(video);
            borrowableVideo.BorrowItem("Customer #1");
            borrowableVideo.BorrowItem("Customer #2");

            borrowableVideo.Show();

            // Wait for user

            Console.ReadKey();
        }
    }
}