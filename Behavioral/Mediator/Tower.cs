using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Jarai.Patterns.Behavioral.Mediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>

    public class Tower
    {
        public string Name { get; }
        private readonly Dictionary<string, Plane> _registeredPlanes = new Dictionary<string, Plane>();

        public Tower(string name)
        {
            Name = name;
        }

        public void Register(Plane plane)
        {
            if (!_registeredPlanes.ContainsKey(plane.Name))
            {
                _registeredPlanes.Add(plane.Name, plane);
            }

            plane.Tower = this;
        }

        public void Send(string to, string text)
        {
            var message = new Message { From = Name, To = to, Text = text };
            Console.WriteLine($"==> {message} (send from {Name})");

            Send(message);
        }

        private void Send(Message message)
        {
            foreach (var plane in _registeredPlanes)
            {
                if (plane.Value.Name != message.From)
                    plane.Value.Receive(message);
            }
        }

        public void Receive(Message message)
        {
            Console.WriteLine($"<== {message} (received by {Name})");
            Send(message);
        }
    }
}