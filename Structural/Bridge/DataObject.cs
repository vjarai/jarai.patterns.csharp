namespace Jarai.Patterns.Structural.Bridge
{
    /// <summary>
    ///     The 'Implementor' abstract class
    /// </summary>
    public abstract class DataObject
    {
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract string GetCurrentRecord();
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void ShowAllRecords();
        public abstract void ShowRecord();
    }
}