using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class Alexa
    {
        readonly List<AlexaSkill> _installedSkills = new List<AlexaSkill>();

        public Alexa()
        {

        }

        public void AddSkill(AlexaSkill newSkill)
        {
            _installedSkills.Add(newSkill);
        }


        public void HandleRequest(string request)
        {
            var requestHandler = _installedSkills.FirstOrDefault(skill => skill.CanHandleRequest(request.ToLower()));

            if (requestHandler == null)
            {
                Console.WriteLine($"Entschuldigung, '{request}' kann ich leider nicht (Fehlt ein Skill?).");
            }
            else
            {
                requestHandler.HandleRequest(request);
            }
        }
    }
}