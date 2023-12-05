using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Structural.Decorator
{
    /// <summary>
    /// Verleiht einem item die Fähigkeit ausgeliehen zu werden.
    /// </summary>
    public class  BorrowableItemDecorator : Item
    {
        private readonly Item _item;
        private readonly List<string> _borrowers = new List<string>();


        public BorrowableItemDecorator(Item item)
        {
            _item = item;
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
        }

        public override void Show()
        {
            _item.Show();

            foreach (var borrower in _borrowers)
                Console.WriteLine(" borrower: " + borrower);
        }
    }
}