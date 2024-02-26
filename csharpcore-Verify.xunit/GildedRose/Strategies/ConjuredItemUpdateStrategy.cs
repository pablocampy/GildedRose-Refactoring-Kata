using GildedRoseKata.Extensions;

namespace GildedRoseKata.Strategies
{
    public class ConjuredItemUpdateStrategy : IItemUpdateStrategy
    {
        public void Update(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality -= 2;
            }
            else if (item.SellIn <= 0)
            {
                item.Quality -= 4;
            }

            item.SellIn -= 1;

            item.EnsureValidValues();
        }
    }
}
