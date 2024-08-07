namespace Jarai.Patterns.Structural.Flyweigth;

public class FormattedText
{
    public string Text { get; set; }

    public string FontName
    {
        get;
        set;
    }

    public int FontSize
    {
        get;
        set;
    }

    public bool IsBold
    {
        get;
        set;
    }

    public bool IsItalic { get; set; }

    public bool IsUnderline { get; set; }

    public override string ToString()
    {
        return $"{Text} {Format}";
    }
}