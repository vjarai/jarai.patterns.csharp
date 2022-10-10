namespace Jarai.Patterns.Other.DependencyInjection.DemoApplication
{
    public class KundenService
    {
        public KundenService(LoggingService loggingService)
        {
            LoggingService = loggingService;
        }

        public LoggingService LoggingService { get; set; }
    }
}