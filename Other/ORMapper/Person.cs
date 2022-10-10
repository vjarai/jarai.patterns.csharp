using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.ORMapper
{
    [Table("Personen")]
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}