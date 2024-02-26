using GildedRoseKata.Extensions;

namespace GildedRoseKata.Strategies
{
    public class BasicItemUpdateStrategy : IItemUpdateStrategy
    {
        public void Update(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality -= 1;
            }
            else if (item.SellIn <= 0)
            {
                item.Quality -= 2;
            }

            item.SellIn -= 1;

            item.EnsureValidValues();
        }
    }
}
