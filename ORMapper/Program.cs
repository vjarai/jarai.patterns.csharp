namespace Jarai.Patterns.ORMapper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Hans" };
            var seminar1 = new Seminar { Name = "Design Patterns" };

            var teilnehmer1 = new Teilnehmer { Name = "Fritz" };
            var teilnehmer2 = new Teilnehmer { Name = "Susi" };

            seminar1.Anmelden(teilnehmer1);
            seminar1.Anmelden(teilnehmer2);

            using (var db = new Database())
            {
                db.Personen.Add(person1);
                db.Seminare.Add(seminar1);
                db.SaveChanges();
            }
        }
    }
}