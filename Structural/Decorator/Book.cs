﻿using System;

namespace Decorator.RealWorld
{
    /// <summary>
    ///     The 'ConcreteComponent' class
    /// </summary>
    public class Book : LibraryItem
    {
        private readonly string author;
        private readonly string title;

        // Constructor

        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", author);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}