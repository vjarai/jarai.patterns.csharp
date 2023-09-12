namespace Jarai.Patterns.Structural.Decorator
{
    public abstract class ItemDecorator : Item
    {
        protected Item Item;

        public ItemDecorator(Item item)
        {
            Item = item;
        }

        public override void Show()
        {
            Item.Show();
        }
    }
}