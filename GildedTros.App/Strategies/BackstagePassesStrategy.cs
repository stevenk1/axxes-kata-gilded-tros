namespace GildedTros.App.Strategies;

public class BackstagePassesStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        var quality = item.Quality;

        item.SellIn--;

        switch (item.SellIn)
        {
            case < 0:
                quality = 0;
                break;
            case < 5:
                quality += 3;
                break;
            case < 10:
                quality += 2;
                break;
            default:
                quality += 1;
                break;
        }

        item.Quality = quality > 50 ? 50 : quality;
    }
}