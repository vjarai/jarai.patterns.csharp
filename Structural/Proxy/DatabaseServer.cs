namespace Jarai.Patterns.Structural.Proxy
{
    public class DatabaseServer
    {
        public virtual string GetData()
        {
            return $"Data from Database...";
        }
    }
}