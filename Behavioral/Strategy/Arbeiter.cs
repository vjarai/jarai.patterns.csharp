namespace Jarai.Patterns.Behavioral.Strategy
{
    public abstract class Arbeiter
    {
        protected string Name;

        public Arbeiter(string name)
        {
            Name = name;
        }

        public abstract void Arbeiten();
    }
}