namespace Jarai.Patterns.Other.DependencyInjection.DemoApplication
{
    public class BuchhaltungsService
    {
        public BuchhaltungsService(KundenService kundenService)
        {
            KundenService = kundenService;
        }

        public KundenService KundenService { get; set; }
    }
}