using System;
using System.Collections.Generic;

namespace Decorator.RealWorld
{
    /// <summary>
    ///     The 'ConcreteDecorator' class
    /// </summary>
    public class Borrowable : Decorator
    {
        protected readonly List<string> Borrowers = new List<string>();

        // Constructor

        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            Borrowers.Add(name);
            LibraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            Borrowers.Remove(name);
            LibraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in Borrowers) Console.WriteLine(" borrower: " + borrower);
        }
    }
}