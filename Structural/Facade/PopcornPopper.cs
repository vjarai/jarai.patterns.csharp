﻿using System;

namespace Jarai.Patterns.Structural.Facade
{
    public class PopcornPopper
    {
        readonly string _description;

        public PopcornPopper(string description)
        {
            _description = description;
        }

        public void On()
        {
            Console.WriteLine(_description + " on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " off");
        }

        public void Pop()
        {
            Console.WriteLine(_description + " popping popcorn!");
        }


        public override string ToString()
        {
            return _description;
        }
    }
}