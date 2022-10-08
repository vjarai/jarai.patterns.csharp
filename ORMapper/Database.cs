using System.Data.Entity;

namespace Jarai.Patterns.ORMapper
{
    public class Database : DbContext
    {
        public DbSet<Seminar> Seminare { get; set; }
        public DbSet<Person> Personen { get; set; }
    }
}