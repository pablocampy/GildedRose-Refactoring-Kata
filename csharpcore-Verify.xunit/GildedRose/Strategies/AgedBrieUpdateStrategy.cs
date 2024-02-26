using GildedRoseKata.Extensions;

namespace GildedRoseKata.Strategies
{
    public class AgedBrieUpdateStrategy : IItemUpdateStrategy
    {
        public void Update(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality += 1;
            }

            item.EnsureValidValues();
        }
    }
}
