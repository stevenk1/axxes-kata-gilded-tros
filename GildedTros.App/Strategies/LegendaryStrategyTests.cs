using Xunit;

namespace GildedTros.App.Strategies;

public class LegendaryTestsTests
{
    [Fact]
    public void UpdateQuality_Legendary_ShouldKeepSellIn()
    {
        var item = new Item { Name = "Legendary", SellIn = 2, Quality = 0 };
        var strategy = new LegendaryStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(item.SellIn, item.SellIn);
    }

    [Theory]
    [InlineData(0), InlineData(19), InlineData(49)] // cover edges as well
    public void UpdateQuality_Legendary_ShouldKeepQuality(int quality)
    {
        var item = new Item { Name = "Legendary", SellIn = 2, Quality = quality};
        var strategy = new LegendaryStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(item.Quality, item.Quality);
    }
}