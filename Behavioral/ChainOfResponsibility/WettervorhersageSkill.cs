using System;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class WettervorhersageSkill : RequestHandler
    {
        public override bool CanHandleRequest(string request)
        {
            return request.Contains("wetter");
        }

        public override void HandleRequest(string request)
        {
            Console.WriteLine($"Morgen, am {DateTime.Today + new TimeSpan(1, 0, 0, 0):dd.MM.yy} scheint die Sonne.");
        }
    }
}