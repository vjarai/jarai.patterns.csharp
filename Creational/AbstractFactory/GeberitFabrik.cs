namespace Jarai.Patterns.Creational.AbstractFactory
{
    public class GeberitFabrik : AbstrakteFabrik
    {
        public override Abzweig CreateAbzweig()
        {
            return new GeberitAbzweig();
        }

        public override Ventil CreateVentil()
        {
            return new GeberitVentil();
        }
    }
}