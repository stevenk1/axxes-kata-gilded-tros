using Xunit;

namespace GildedTros.App.Strategies;

public class GoodWineStrategyTests
{
    [Fact]
    public void UpdateQuality_GoodWineStrategy_ShouldDecreaseSellIn()
    {
        var item = new Item { Name = "Good Wine", SellIn = 2, Quality = 0 };
        var strategy = new GoodWineStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(1, item.SellIn);
    }

    [Theory]
    [InlineData(0), InlineData(19), InlineData(49)] // cover edges as well
    public void UpdateQuality_GoodWineStrategy_ShouldIncreaseQuality(int quality)
    {
        var item = new Item { Name = "Good Wine", SellIn = 2, Quality = quality};
        var strategy = new GoodWineStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(quality+1, item.Quality);
    }
    
    [Theory]
    [InlineData(0, 14), InlineData(-1, 19)] // cover edges as well
    public void UpdateQuality_GoodWineStrategy_ShouldIncreaseQualityTwiceAsFastWhenSellinNegative(int sellIn,
        int quality)
    {
        var item = new Item { Name = "an item", SellIn = sellIn, Quality = quality };
        var strategy = new GoodWineStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(quality + 2, item.Quality);
    }

    [Theory]
    [InlineData(10, 50), InlineData(0, 49)] // cover edges as well

    public void UpdateQuality_GoodWineStrategy_ShouldNeverHaveQualityHigherThan50(int sellIn,
    int quality)
    {
        var item = new Item { Name = "Good Wine", SellIn = sellIn, Quality = quality};
        var strategy = new GoodWineStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(50, item.Quality);
    }
}