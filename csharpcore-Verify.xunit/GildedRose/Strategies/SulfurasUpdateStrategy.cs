namespace GildedRoseKata.Strategies
{
    public class SulfurasUpdateStrategy : IItemUpdateStrategy
    {
        public void Update(Item item)
        {
            item.Quality = 80;
        }
    }
}
