using System;
using System.Collections.Generic;
using System.Linq;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class Alexa
    {
        private List<AlexaSkill> _installedSkills = new List<AlexaSkill>();

        public void InstallAllSkills()
        {
            // Erstellt Instanzen von allen Klassen, die von AlexaSkill abgeleitet sind.
            _installedSkills = (from type in GetType().Assembly.GetTypes()
                where !type.IsAbstract && typeof(AlexaSkill).IsAssignableFrom(type)
                select (AlexaSkill)Activator.CreateInstance(type)).ToList();
        }

        public void InstallSkill(AlexaSkill newSkill)
        {
            _installedSkills.Add(newSkill);
        }


        public void HandleRequest(string request)
        {
            var requestHandler = _installedSkills.FirstOrDefault(skill => skill.CanHandleRequest(request.ToLower()));

            if (requestHandler == null)
                Console.WriteLine($"Entschuldigung, '{request}' kann ich leider nicht (Fehlt ein Skill?).");
            else
                requestHandler.HandleRequest(request);
        }
    }
}