using GildedRoseKata.Extensions;

namespace GildedRoseKata.Strategies
{
    public class ConjuredItemUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.SellIn -= 1;
            }

            if (item.SellIn > 0)
            {
                item.Quality -= 2;
            }
            else if (item.SellIn == 0)
            {
                item.SellIn -= 4;
            }

            item.EnsureNoNegativeQuality();
        }
    }
}
