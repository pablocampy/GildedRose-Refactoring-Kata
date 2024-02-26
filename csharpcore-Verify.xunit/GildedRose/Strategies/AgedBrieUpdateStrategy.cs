namespace GildedRoseKata.Strategies
{
    public class AgedBrieUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.SellIn -= 1;
            }

            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }
    }
}
