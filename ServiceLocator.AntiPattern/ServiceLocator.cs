namespace ServiceLocator.AntiPattern
{
    /// <summary>
    /// Servicelocator ANTI Pattern
    /// Warum Antipattern: Testbarkeit, Mockbarkeit, unsichtbare Abhängigkeiten.
    /// </summary>
    public class ServiceLocator
    {
        public static T Resolve<T>() where T : class, new()
        {
            return new T();
        }
    }
}