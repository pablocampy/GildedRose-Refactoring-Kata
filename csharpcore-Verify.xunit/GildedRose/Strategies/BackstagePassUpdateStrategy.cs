using GildedRoseKata.Extensions;

namespace GildedRoseKata.Strategies
{
    public class BackstagePassUpdateStrategy : IItemUpdateStrategy
    {
        public void Update(Item item)
        {
            if (item != null)
            {
                item.Quality = item.SellIn switch
                {
                    > 10 => item.Quality + 1,
                    <= 10 and > 5 => item.Quality + 2,
                    <= 5 and > 0 => item.Quality + 3,
                    _ => 0,
                };

                item.SellIn -= 1;

                item.EnsureValidValues();
            }
        }
    }
}
