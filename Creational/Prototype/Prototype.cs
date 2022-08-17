namespace Jarai.Patterns.Creational.Prototype
{
    /// <summary>
    ///     The 'Prototype' abstract class
    /// </summary>
    public abstract class Prototype
    {
        // Constructor
        public Prototype(string id)
        {
            Id = id;
        }

        // Gets id
        public string Id { get; }

        public abstract Prototype Clone();
    }
}