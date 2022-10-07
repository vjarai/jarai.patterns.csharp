namespace Jarai.Patterns.Other.DependencyInjection.DemoApplication
{
    public class ErpApplication
    {
        public ErpApplication(BuchhaltungsService buchhaltungsService, LagerService lagerService, LoggingService loggingService)
        {
            BuchhaltungsService = buchhaltungsService;
            LagerService = lagerService;
            LoggingService = loggingService;
        }

        public void Run()
        {
            LoggingService.WriteLog("Erp Apllication started.");
        }

        public BuchhaltungsService BuchhaltungsService { get; set; }

        public LagerService LagerService { get; set; }

        public LoggingService LoggingService { get; set; }
    }
}