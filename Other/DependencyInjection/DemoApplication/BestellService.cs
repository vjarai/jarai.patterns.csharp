namespace Jarai.Patterns.Other.DependencyInjection.DemoApplication
{
    public class BestellService
    {
        public BestellService(LoggingService loggingService)
        {
            LoggingService = loggingService;
        }

        public LoggingService LoggingService { get; set; }
    }
}