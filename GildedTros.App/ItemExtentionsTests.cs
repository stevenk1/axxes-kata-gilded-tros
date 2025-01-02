using Xunit;

namespace GildedTros.App;

public class ItemExtentionsTests
{
    [Fact]
    public void IsExpired_ItemExtentionsTests_ShouldReturnFalse_WhenNotExpired()
    {
        var item = new Item { Name = "an item", SellIn = 0, Quality = 0 };
        Assert.False(item.IsExpired());
    }

    [Fact]
    public void IsExpired_ItemExtentionsTests_ShouldReturnTrue_WhenExpired()
    {
        var item = new Item { Name = "an item", SellIn = -1, Quality = 0 };
        Assert.True(item.IsExpired());
    }

    [Fact]
    public void IncrementQuality_ItemExtentionsTests_ShouldIncrementQuality()
    {
        var item = new Item { Name = "an item", SellIn = 1, Quality = 1 };
        item.IncrementQuality();
        Assert.Equal(2, item.Quality);
    }

    [Fact]
    public void IncrementQuality_ItemExtentionsTests_ShouldNotIncrementHigherThan50()
    {
        var item = new Item { Name = "an item", SellIn = 1, Quality = 50 };
        item.IncrementQuality();
        Assert.Equal(50, item.Quality);
    }

    [Fact]
    public void IncrementQualityBy_ItemExtentionsTests_ShouldIncrementQuality()
    {
        var item = new Item { Name = "an item", SellIn = 1, Quality = 1 };
        item.IncrementQualityBy(3);
        Assert.Equal(4, item.Quality);
    }

    [Fact]
    public void IncrementQualityBy_ItemExtentionsTests_ShouldNotIncrementHigherThan50()
    {
        var item = new Item { Name = "an item", SellIn = 1, Quality = 49 };
        item.IncrementQualityBy(3);
        Assert.Equal(50, item.Quality);
    }

    [Fact]
    public void DecrementQuality_ItemExtentionsTests_ShouldDecrementQuality()
    {
        var item = new Item { Name = "an item", SellIn = -1, Quality = 2 };
        item.DecrementQuality();
        Assert.Equal(1, item.Quality);
    }

    [Fact]
    public void DecrementQuality_ItemExtentionsTests_ShouldNotDecrementLowerThan0()
    {
        var item = new Item { Name = "an item", SellIn = -1, Quality = 0 };
        item.DecrementQuality();
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void DecrementQualityByItemExtentionsTests_ShouldDecrementQuality()
    {
        var item = new Item { Name = "an item", SellIn = -1, Quality = 5 };
        item.DecrementQualityBy(2);
        Assert.Equal(3, item.Quality);
    }

    [Fact]
    public void DecrementQualityBy_ItemExtentionsTests_ShouldNotDecrementLowerThan0()
    {
        var item = new Item { Name = "an item", SellIn = -1, Quality = 2 };
        item.DecrementQualityBy(3);
        Assert.Equal(0, item.Quality);
    }
}