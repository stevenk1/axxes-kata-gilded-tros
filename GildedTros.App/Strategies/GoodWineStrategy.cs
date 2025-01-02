namespace GildedTros.App.Strategies;

public class GoodWineStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;
        item.IncrementQuality();

        if (item.IsExpired())
            item.IncrementQuality();
    }
}