using System;

namespace Jarai.Patterns.Structural.Decorator
{
    public class Video : Item
    {
        public string Director { get; set; }
        public int PlayTime { get; set; }
        public string Title { get; set; }


        public override void Show()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", Director);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", PlayTime);
        }
    }
}