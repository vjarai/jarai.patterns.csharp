namespace Jarai.Patterns.Structural.Flyweigth;

/// <summary>
///     Flyweight Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        var textDocument = new TextDocument();

        textDocument.AddText("Hello1");
        textDocument.AddText("Hello1");

        textDocument.AddText("Hello2", "Arial", 12);
        textDocument.AddText("Hello2", "Arial", 12);

        textDocument.AddText("Hello3", "Arial", 12, true);
        textDocument.AddText("Hello3", "Arial", 12, true);

        textDocument.AddText("Hello4", "Arial", 12, true, true);
        textDocument.AddText("Hello4", "Arial", 12, true, true);

        textDocument.Show();
    }
}

// ... C, D, E, etc.