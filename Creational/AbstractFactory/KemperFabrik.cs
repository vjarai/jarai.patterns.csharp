namespace Jarai.Patterns.Creational.AbstractFactory
{
    public class KemperFabrik : AbstrakteFabrik
    {
        public override Abzweig CreateAbzweig()
        {
            return new KemperAbzweig();
        }

        public override Ventil CreateVentil()
        {
            return new KemperVentil();
        }
    }
}