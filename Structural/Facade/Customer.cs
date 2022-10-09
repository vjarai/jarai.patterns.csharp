namespace Jarai.Patterns.Structural.Facade
{
    /// <summary>
    /// Customer class
    /// </summary>

    public class Customer
    {
        private readonly string _name;

        // Constructor

        public Customer(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}