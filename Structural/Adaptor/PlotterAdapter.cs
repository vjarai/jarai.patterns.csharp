namespace Jarai.Patterns.Structural.Adapter
{
    public class PlotterAdapter : Drucker
    {
        private readonly Plotter _plotter;

        public PlotterAdapter(Plotter plotter)
        {
            _plotter = plotter;
        }

        public override void Drucken(string text)
        {
            _plotter.Plotten(text);
        }
    }
}