using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        [Fact]
        public void UpdateQuality_GildedTros_ShouldUpdateQuality()
        {
            IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = 6, Quality = 13 } };
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();
            Assert.Equal("foo", items[0].Name);
            Assert.Equal(5, items[0].SellIn);
            Assert.Equal(12, items[0].Quality);
        }
    }
}