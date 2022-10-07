using Jarai.Patterns.Other.DependencyInjection.Container;
using Jarai.Patterns.Other.DependencyInjection.DemoApplication;

namespace Jarai.Patterns.Other.DependencyInjection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new SimpleIocContainer();

            var application = container.Resolve<ErpApplication>();
            application.Run();
        }
    }
}