using System;

namespace Decorator.RealWorld
{
    /// <summary>
    ///     The 'ConcreteComponent' class
    /// </summary>
    public class Book : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;

        // Constructor

        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}