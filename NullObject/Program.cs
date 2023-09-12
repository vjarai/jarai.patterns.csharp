namespace NullObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Write("Hallo");

            myLogger = new NullLogger();
            myLogger.Write("Welt");

        }
    }
}