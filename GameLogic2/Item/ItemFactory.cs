namespace GoblinMode.Item
{
    public abstract class ItemFactory<T> where T : Item
    {
        public abstract T CreateItem();
    }
}
