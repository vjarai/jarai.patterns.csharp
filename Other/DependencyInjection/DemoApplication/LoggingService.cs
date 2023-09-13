using System.Diagnostics;

namespace Jarai.Patterns.Other.DependencyInjection.DemoApplication
{
    public class LoggingService : ILoggingService
    {
        
        public void WriteLog(string message)
        {
            Debug.WriteLine(message);
        }
    }
}