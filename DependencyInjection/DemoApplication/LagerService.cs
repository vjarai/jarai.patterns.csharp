namespace Jarai.Patterns.Other.DependencyInjection.DemoApplication
{
    public class LagerService
    {
        public LagerService(BestellService bestellService, VersandService versandService)
        {
            BestellService = bestellService;
            VersandService = versandService;
        }

        public BestellService BestellService { get; set; }

        public VersandService VersandService { get; set; }
    }
}