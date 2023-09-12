using System;

namespace Jarai.Patterns.Structural.Flyweigth
{
    /// <summary>
    ///     Flyweight Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            // Build a document with text

            var document = "AAZZBBZB";
            var chars = document.ToCharArray();

            var factory = new CharacterFactory();

            // extrinsic state

            var pointSize = 10;

            // For each character use a flyweight object

            foreach (var c in chars)
            {
                pointSize++;
                var character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            // Wait for user

            Console.ReadKey();
        }
    }

    // ... C, D, E, etc.
}