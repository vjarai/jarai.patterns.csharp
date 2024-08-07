namespace Jarai.Patterns.Structural.Flyweigth;

public class FlyweightText
{
    public string Text { get; set; }

    public Format Format { get; set; }

    public override string ToString()
    {
        return $"{Text} {Format}";
    }
}