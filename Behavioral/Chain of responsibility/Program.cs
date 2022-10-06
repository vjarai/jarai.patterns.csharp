using System;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lisa = new Person("Lisa");
            var susi = new Person("Susi", lisa);
            var fritz = new Person("Fritz", susi);

            // Experten trainieren...
            fritz.LerneAntwort("Eins", "one");
            fritz.LerneAntwort("Zwei", "two");
            fritz.LerneAntwort("Drei", "three");

            susi.LerneAntwort("M", "80123");
            susi.LerneAntwort("FFM", "60750");
            susi.LerneAntwort("H", "40123");

            lisa.LerneAntwort("1+1", "2");
            lisa.LerneAntwort("1+2", "3");
            lisa.LerneAntwort("2x2", "4");

            while (true)
            {
                Console.WriteLine("\nWas wollen Sie von Fritz wissen?");
                var meineFrage = Console.ReadLine();

                if (string.IsNullOrEmpty(meineFrage))
                    break;

                try
                {
                    // Frage an Fritz stellen
                    var antwort = fritz.BeantworteFrage(meineFrage);

                    // Antwort kann auch von einem befreundeten Experten kommen!
                    Console.WriteLine(antwort);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();
        }
    }
}