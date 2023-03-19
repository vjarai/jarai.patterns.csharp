﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class WettervorhersageSkill : AlexaSkill
    {
        public override bool CanHandleRequest(string request)
        {
            return request.Contains("wetter");
        }

        public override void HandleRequest(string request)
        {
            Console.WriteLine($"Morgen, am {DateTime.Today + new TimeSpan(1, 0, 0, 0) :dd.MM.yy} scheint die Sonne.");
        }
    }
}