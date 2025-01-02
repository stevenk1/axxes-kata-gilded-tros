namespace GildedTros.App.Strategies;

public class DefaultStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;
        item.DecrementQuality();

        if (item.IsExpired())
            item.DecrementQuality();
    }
}