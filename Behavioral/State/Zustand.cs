using System;

namespace Jarai.Patterns.Behavioral.State
{
    public abstract class Zustand
    {
        public virtual Zustand Abheben()
        {
            Console.WriteLine("Telefon kann nicht abgehben werden!");
            return this;
        }

        public virtual Zustand Annehmen()
        {
            Console.WriteLine("Telefon kann nicht angenommen werden!");
            return this;
        }

        public virtual Zustand Auflegen()
        {
            Console.WriteLine("Telefon kann nicht aufgelegt werden!");
            return this;
        }

        public virtual Zustand Sprechen()
        {
            Console.WriteLine("Mit dem Telefon kann nicht gesprochen werden!");
            return this;
        }

        public override string ToString()
        {
            return GetType().Name;
        }

        public virtual Zustand Wählen()
        {
            Console.WriteLine("Telefon kann nicht gewählt werden!");
            return this;
        }
    }
}