using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jarai.Patterns.ORMapper
{
    [Table("Seminare")]
    public class Seminar // Persistenz ignorant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Teilnehmer> Teilnehmer { get; set; } = new List<Teilnehmer>();

        public void Anmelden(Teilnehmer neuerTeilnehmer)
        {
            Teilnehmer.Add(neuerTeilnehmer);
            neuerTeilnehmer.Seminare.Add(this);
        }
    }
}