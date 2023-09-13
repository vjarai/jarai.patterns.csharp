using System.Collections.Generic;

namespace Jarai.Patterns.ORMapper
{
    public class Teilnehmer : Person
    {

        public List<Seminar> Seminare { get; set; } = new List<Seminar>();
    }
}