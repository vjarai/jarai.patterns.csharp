using System;

namespace Jarai.Patterns.Structural.Decorator
{
    public class Book : Item
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public override void Show()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", Author);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}