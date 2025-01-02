namespace GildedTros.App.Strategies;

public class SmellyItemsStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;

        item.DecrementQualityBy(2);

        if (item.IsExpired()) item.DecrementQualityBy(2);
    }
}