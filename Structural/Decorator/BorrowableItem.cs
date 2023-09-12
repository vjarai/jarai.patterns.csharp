using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Structural.Decorator
{
    public class BorrowableItem : ItemDecorator
    {
        private readonly List<string> _borrowers = new List<string>();

        // Constructor

        public BorrowableItem(Item item)
            : base(item)
        {
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            Item.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            Item.NumCopies++;
        }

        public override void Show()
        {
            base.Show();

            foreach (var borrower in _borrowers)
                Console.WriteLine(" borrower: " + borrower);
        }
    }
}