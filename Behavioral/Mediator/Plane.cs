using System;

namespace Jarai.Patterns.Behavioral.Mediator
{
    public class Plane
    {

        public Plane(string name)
        {
            Name = name;
        }


        public string Name { get; }


        public Tower Tower { set; get; }


        public void Connect(Tower tower)
        {
            Tower = tower;
            Tower.Register(this);
        }


        public void Send(string text)
        {
            var message = new Message { From = Name, To = "Tower", Text = text };

            Console.WriteLine($"==> {message} (send from {Name})");
            Tower.Receive(message);
        }


        public virtual void Receive(Message message)
        {
            Console.WriteLine($"<== {message} (received by {Name})");
        }
    }
}