using GildedTros.App.Strategies;
using Xunit;

namespace GildedTros.App.Factories;

public class ItemQualityUpdateStrategyFactoryTests
{
    [Fact]
    public void Create_ItemQualityUpdateStrategyFactory_ShouldReturnCorrectStrategyWhenGoodWine()
    {
        var strategy = new ItemQualityUpdateStrategyFactory().Create(new Item { Name = "Good Wine" });
        Assert.NotNull(strategy);
        Assert.IsType<GoodWineStrategy>(strategy);
    }

    [Fact]
    public void Create_ItemQualityUpdateStrategyFactory_ShouldReturnCorrectStrategyWhenFoo()
    {
        var strategy = new ItemQualityUpdateStrategyFactory().Create(new Item { Name = "Foo" });
        Assert.NotNull(strategy);
        Assert.IsType<DefaultStrategy>(strategy);
    }

    [Fact]
    public void Create_ItemQualityUpdateStrategyFactory_ShouldReturnCorrectLegendaryStrategy()
    {
        var strategy = new ItemQualityUpdateStrategyFactory().Create(new Item { Name = "B-DAWG Keychain" });
        Assert.NotNull(strategy);
        Assert.IsType<LegendaryStrategy>(strategy);
    }

    [Theory]
    [InlineData("Backstage passes for Re:factor")]
    [InlineData("Backstage passes for HAXX")]
    public void Create_ItemQualityUpdateStrategyFactory_ShouldReturnCorrectBackstagePassStrategy(string name)
    {
        var strategy = new ItemQualityUpdateStrategyFactory().Create(new Item { Name = name });
        Assert.NotNull(strategy);
        Assert.IsType<BackstagePassesStrategy>(strategy);
    }

    [Theory]
    [InlineData("Ring of Cleansening Code")]
    [InlineData("Elixir of the SOLID")]
    public void Create_ItemQualityUpdateStrategyFactory_ShouldReturnCorrectDefaultStrategy(string name)
    {
        var strategy = new ItemQualityUpdateStrategyFactory().Create(new Item { Name = name });
        Assert.NotNull(strategy);
        Assert.IsType<DefaultStrategy>(strategy);
    }

    [Theory]
    [InlineData("Duplicate Code")]
    [InlineData("Long Methods")]
    [InlineData("Ugly Variable Names")]
    public void Create_ItemQualityUpdateStrategyFactory_ShouldReturnCorrectSmellyItemsStrategy(string name)
    {
        var strategy = new ItemQualityUpdateStrategyFactory().Create(new Item { Name = name });
        Assert.NotNull(strategy);
        Assert.IsType<SmellyItemsStrategy>(strategy);
    }
}