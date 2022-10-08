using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jarai.Patterns.ORMapper
{
    public class Teilnehmer : Person
    {

        public List<Seminar> Seminare { get; set; } = new List<Seminar>();
    }
}