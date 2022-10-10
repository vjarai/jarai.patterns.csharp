namespace Jarai.Patterns.Other.DependencyInjection.DemoApplication
{
    public class VersandService
    {
        public VersandService(LoggingService loggingService)
        {
            LoggingService = loggingService;
        }

        public LoggingService LoggingService { get; set; }
    }
}