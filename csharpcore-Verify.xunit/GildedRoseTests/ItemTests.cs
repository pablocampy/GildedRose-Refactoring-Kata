using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class ItemTests
    {
        [Theory]
        [InlineData(50, 49)]
        [InlineData(25, 24)]
        [InlineData(1, 0)]
        [InlineData(0, 0)]
        public void BasicItem_UpdateQualityOnce_QualityIsCorrectValue(int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = startingQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}
