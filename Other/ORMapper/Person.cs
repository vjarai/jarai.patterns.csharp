using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jarai.Patterns.ORMapper
{
    [Table("Personen")]
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}