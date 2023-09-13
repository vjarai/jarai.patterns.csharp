namespace Jarai.Patterns.Behavioral.Memento
{
    /// <summary>
    /// Memento Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            var document = new Document();
            var undoBuffer = new UndoBuffer(document);

            document.SetText("Hallo");
            document.Show();

            undoBuffer.SaveDocument();

            document.SetText("Welt");
            document.Show();

            undoBuffer.RestoreDocument(0);
            document.Show();
        }
    }
}
