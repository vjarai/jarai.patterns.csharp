﻿using System;
using System.Collections.Generic;

namespace Decorator.RealWorld
{
    /// <summary>
    ///     The 'ConcreteDecorator' class
    /// </summary>
    public class Borrowable : Decorator
    {
        protected readonly List<string> borrowers = new List<string>();

        // Constructor

        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers) Console.WriteLine(" borrower: " + borrower);
        }
    }
}