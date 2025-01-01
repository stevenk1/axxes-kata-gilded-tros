namespace GildedTros.App.Strategies;

public class GoodWineStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;
        if (item.Quality < 50)
        {
            item.Quality++;
        }
        
        if (item.SellIn < 0)
        {
            if (item.Quality < 50) item.Quality++;
        }
    }
}