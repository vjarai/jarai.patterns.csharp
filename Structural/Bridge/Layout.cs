namespace Jarai.Patterns.Structural.Bridge
{
    public abstract class Layout {

        public abstract void  PrintLine();

        public abstract void PrintDecor();

        public abstract void PrintText(string text);
    }
}
