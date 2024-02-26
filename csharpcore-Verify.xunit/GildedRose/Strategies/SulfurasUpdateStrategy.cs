namespace GildedRoseKata.Strategies
{
    public class SulfurasUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = 80;
        }
    }
}
