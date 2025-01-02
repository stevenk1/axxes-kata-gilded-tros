namespace GildedTros.App.Strategies;

public class BackstagePassesStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;

        switch (item.SellIn)
        {
            case < 0:
                item.Quality = 0;
                break;
            case < 5:
                item.IncrementQualityBy(3);
                break;
            case < 10:
                item.IncrementQualityBy(2);
                break;
            default:
                item.IncrementQuality();
                break;
        }
    }
}