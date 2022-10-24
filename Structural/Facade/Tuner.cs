﻿using System;

namespace Jarai.Patterns.Structural.Facade
{
    public class Tuner
    {
        String _description;
        Amplifier _amplifier;
        double _frequency;

        public Tuner(String description, Amplifier amplifier)
        {
            this._description = description;
        }

        public void On()
        {
            Console.WriteLine(_description + " on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " off");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine(_description + " setting frequency to " + frequency);
            this._frequency = frequency;
        }

        public void SetAm()
        {
            Console.WriteLine(_description + " setting AM mode");
        }

        public void SetFm()
        {
            Console.WriteLine(_description + " setting FM mode");
        }

        public override String ToString()
        {
            return _description;
        }
    }
}