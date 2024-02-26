using System.Collections.Generic;
using GildedRoseKata.Strategies;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                var strategyContext = new StrategyContext(item.Name);
                strategyContext.ExecuteStrategy(item);
            }
        }
    }
}
