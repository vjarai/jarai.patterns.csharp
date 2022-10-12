﻿using System;

namespace Decorator.RealWorld
{
    /// <summary>
    ///     The 'ConcreteComponent' class
    /// </summary>
    public class Video : LibraryItem
    {
        private readonly string _director;
        private readonly int _playTime;
        private readonly string _title;

        // Constructor

        public Video(string director, string title, int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}