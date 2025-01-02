namespace GildedTros.App.Strategies;

public class SmellyItemsStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;

        var quality = item.Quality;
        quality -= 2;

        if (item.IsExpired()) quality -= 2;


        item.Quality = quality > 0 ? quality : 0;
    }
}