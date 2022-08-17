namespace Jarai.Patterns.Behavioral.Observer
{
    public interface IBeobachtbar
    {
        void AddBeobachter(IBeobachter beobachter);

        void RemoveBeobachter(IBeobachter beobachter);
    }
}