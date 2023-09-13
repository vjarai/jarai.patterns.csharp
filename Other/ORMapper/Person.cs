using System.ComponentModel.DataAnnotations.Schema;

namespace Jarai.Patterns.ORMapper
{
    [Table("Personen")]
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}