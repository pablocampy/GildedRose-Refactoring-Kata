using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class ItemTests
    {
        [Theory]
        [InlineData(50, 49)]
        [InlineData(49, 48)]
        [InlineData(2, 1)]
        [InlineData(1, 0)]
        [InlineData(0, 0)]
        public void BasicItem_UpdateQualityOnce_QualityIsCorrectValue(int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> { 
                new Item { 
                    Name = "foo", 
                    SellIn = 1, 
                    Quality = startingQuality 
                } 
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

        [Theory]
        [InlineData(50, 48)]
        [InlineData(49, 47)]
        [InlineData(3, 1)]
        [InlineData(2, 0)]
        [InlineData(1, 0)]
        [InlineData(0, 0)]
        public void BasicItemWithSellByDatePassed_UpdateQualityOnce_QualityIsCorrectValue(int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "foo",
                    SellIn = 0,
                    Quality = startingQuality
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

        [Theory]
        [InlineData(50, 50)]
        [InlineData(49, 50)]
        [InlineData(1, 2)]
        [InlineData(0, 1)]
        public void AgedBrie_UpdateQualityOnce_QualityIsCorrectValue(int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Aged Brie",
                    SellIn = 10,
                    Quality = startingQuality
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

        [Theory]
        [InlineData(50, 50)]
        [InlineData(49, 50)]
        [InlineData(48, 50)]
        [InlineData(1, 3)]
        [InlineData(0, 2)]
        public void AgedBrieWithSellByDatePassed_UpdateQualityOnce_QualityIsCorrectValue(int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Aged Brie",
                    SellIn = 0,
                    Quality = startingQuality
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

        [Fact]
        public void SulfurasHandOfRagnaros_UpdateQualityOnce_QualityIsCorrectValue()
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 10,
                    Quality = 80
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(80, Items[0].Quality);
        }

        [Theory]
        [InlineData(int.MaxValue, 50, 50)]
        [InlineData(int.MaxValue, 49, 50)]
        [InlineData(int.MaxValue, 0, 1)]
        [InlineData(11, 50, 50)]
        [InlineData(11, 49, 50)]
        [InlineData(11, 0, 1)]
        [InlineData(10, 50, 50)]
        [InlineData(10, 49, 50)]
        [InlineData(10, 48, 50)]
        [InlineData(10, 47, 49)]
        [InlineData(10, 1, 3)]
        [InlineData(10, 0, 2)]
        [InlineData(9, 50, 50)]
        [InlineData(9, 49, 50)]
        [InlineData(9, 48, 50)]
        [InlineData(9, 47, 49)]
        [InlineData(9, 1, 3)]
        [InlineData(9, 0, 2)]
        [InlineData(6, 50, 50)]
        [InlineData(6, 49, 50)]
        [InlineData(6, 48, 50)]
        [InlineData(6, 47, 49)]
        [InlineData(6, 1, 3)]
        [InlineData(6, 0, 2)]
        [InlineData(5, 50, 50)]
        [InlineData(5, 49, 50)]
        [InlineData(5, 48, 50)]
        [InlineData(5, 47, 50)]
        [InlineData(5, 46, 49)]
        [InlineData(5, 1, 4)]
        [InlineData(5, 0, 3)]
        [InlineData(4, 50, 50)]
        [InlineData(4, 49, 50)]
        [InlineData(4, 48, 50)]
        [InlineData(4, 47, 50)]
        [InlineData(4, 46, 49)]
        [InlineData(4, 1, 4)]
        [InlineData(4, 0, 3)]
        [InlineData(0, 50, 0)]
        [InlineData(0, 49, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 0)]
        public void BackstagePasses_UpdateQualityOnce_QualityIsCorrectValue(int initialSellInValue, int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = initialSellInValue,
                    Quality = startingQuality
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

        [Theory]
        [InlineData(50, 48)]
        [InlineData(49, 47)]
        [InlineData(3, 1)]
        [InlineData(2, 0)]
        [InlineData(1, 0)]
        [InlineData(0, 0)]
        public void ConjuredItem_UpdateQualityOnce_QualityIsCorrectValue(int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Conjured",
                    SellIn = 10,
                    Quality = startingQuality
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

        [Theory]
        [InlineData(50, 46)]
        [InlineData(49, 45)]
        [InlineData(5, 1)]
        [InlineData(4, 0)]
        [InlineData(1, 0)]
        [InlineData(0, 0)]
        public void ConjuredItemWithSellByDatePassed_UpdateQualityOnce_QualityIsCorrectValue(int startingQuality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Conjured",
                    SellIn = 0,
                    Quality = startingQuality
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}
