using GildedRoseKata.Extensions;

namespace GildedRoseKata.Strategies
{
    public class BasicItemUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.SellIn -= 1;
            }

            if (item.SellIn > 0)
            {
                item.Quality -= 1;
            }
            else if (item.SellIn == 0)
            {
                item.SellIn -= 2;
            }

            item.EnsureNoNegativeQuality();
        }
    }
}
