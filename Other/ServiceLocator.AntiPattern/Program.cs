namespace ServiceLocator.AntiPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bad smell: Service via Servicelocator auflösen (nicht testbar)
            // Richtig wäre: Benötigte Services via Constructor Injection übergeben
            var myService = ServiceLocator.Resolve<TestService>();
        }
    }
}
