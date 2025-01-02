using Xunit;

namespace GildedTros.App.Strategies;

public class SmellyItemsStrategyTests
{
    [Fact]
    public void UpdateQuality_SmellyItemsStrategy_ShouldDecreaseSellIn()
    {
        var item = new Item { Name = "an item", SellIn = 2, Quality = 0 };
        var strategy = new SmellyItemsStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(1, item.SellIn);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(19)]
    [InlineData(50)] // cover edges as well
    public void UpdateQuality_SmellyItemsStrategy_ShouldDecreaseQuality(int quality)
    {
        var item = new Item { Name = "an item", SellIn = 2, Quality = quality };
        var strategy = new SmellyItemsStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(quality - 2, item.Quality);
    }

    [Theory]
    [InlineData(0, 14)]
    [InlineData(-1, 19)] // cover edges as well
    public void UpdateQuality_SmellyItemsStrategy_ShouldDecreaseQualityTwiceAsFastWhenSellinNegative(int sellIn,
        int quality)
    {
        var item = new Item { Name = "an item", SellIn = sellIn, Quality = quality };
        var strategy = new SmellyItemsStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(quality - 4, item.Quality);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(0, 1)]
    [InlineData(0, 3)]
    [InlineData(5, 1)] // cover edges as well]
    public void UpdateQuality_SmellyItemsStrategy_ShouldNeverHaveQualityLowerThan0(int sellIn, int quality)
    {
        var item = new Item { Name = "an item", SellIn = sellIn, Quality = quality };
        var strategy = new SmellyItemsStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(0, item.Quality);
    }
}