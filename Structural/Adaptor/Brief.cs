namespace Jarai.Patterns.Structural.Adapter
{
    public class Brief
    {
        private readonly string _text;

        public Brief(string text)
        {
            _text = text;
        }

        public void Ausdrucken(Drucker dr)
        {
            dr.Drucken(_text);
        }
    }
}