namespace Jarai.Patterns.Creational.AbstractFactory
{
    public abstract class AbstrakteFabrik
    {
        public abstract Abzweig CreateAbzweig();

        public abstract Ventil CreateVentil();
    }
}