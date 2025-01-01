using Xunit;

namespace GildedTros.App.Strategies;

public class BackstagePassesStrategyTests
{
    [Fact]
    public void UpdateQuality_BackstagePassesStrategy_ShouldDecreaseSellIn()
    {
        var item = new Item { Name = "Backstage pass", SellIn = 2, Quality = 0 };
        var strategy = new BackstagePassesStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(1, item.SellIn);
    }

    [Theory]
    [InlineData(1,0), InlineData(2,19), InlineData(5,32)] // cover edges as well
    public void UpdateQuality_BackstagePassesStrategy_ShouldIncreaseQualityBy3WhenSellIn5OrLess(int sellIn,int quality)
    {
        var item = new Item { Name = "Backstage pass", SellIn = sellIn, Quality = quality};
        var strategy = new BackstagePassesStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(quality+3, item.Quality);
    }
    
    [Theory]
    [InlineData(7,0), InlineData(7,19), InlineData(10,32)] // cover edges as well
    public void UpdateQuality_BackstagePassesStrategy_ShouldIncreaseQualityBy2WhenSellIn10OrLess(int sellIn,int quality)
    {
        var item = new Item { Name = "Backstage pass", SellIn = sellIn, Quality = quality};
        var strategy = new BackstagePassesStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(quality+2, item.Quality);
    }
    
    [Theory]
    [InlineData(12,0), InlineData(12,19), InlineData(12,49)] // cover edges as well
    public void UpdateQuality_BackstagePassesStrategy_ShouldIncreaseQualityWhenSellInMoreThan10(int sellIn,int quality)
    {
        var item = new Item { Name = "Backstage pass", SellIn = sellIn, Quality = quality};
        var strategy = new BackstagePassesStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(quality+1, item.Quality);
    }
    
    [Theory]
    [InlineData(0,0), InlineData(0,19),InlineData(-1,19)] // cover edges as well
    public void UpdateQuality_BackstagePassesStrategy_ShouldHaveQuality0WhenSellInLowerThan0(int sellIn,int quality)
    {
        var item = new Item { Name = "Backstage pass", SellIn = sellIn, Quality = quality};
        var strategy = new BackstagePassesStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(0, item.Quality);
    }
    
    [Theory]
    [InlineData(2,50), InlineData(7,50),InlineData(2,48), InlineData(7,49)] // cover edges as well
    public void UpdateQuality_BackstagePassesStrategy_ShouldNeverBeHigherThan50(int sellIn,int quality)
    {
        var item = new Item { Name = "Backstage pass", SellIn = sellIn, Quality = quality};
        var strategy = new BackstagePassesStrategy();
        strategy.UpdateQuality(item);
        Assert.Equal(50, item.Quality);
    }
}