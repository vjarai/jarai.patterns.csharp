using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class LampenSkill : AlexaSkill
    {
        public override bool CanHandleRequest(string request)
        {
            return request.Contains("licht");
        }

        public override void HandleRequest(string request)
        {
            var parameter = GetFirstWordAfter(request, "Licht", "<DefaultLampe>");
            Console.WriteLine($"Schalte Lampe {parameter} ein.");
        }
    }
}