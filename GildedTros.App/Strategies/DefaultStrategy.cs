namespace GildedTros.App.Strategies;

public class DefaultStrategy : IItemQualityUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;
        if (item.Quality > 0)
        {
            item.Quality--;
        }
        
        if (item.SellIn < 0)
        {
            if (item.Quality > 0) item.Quality--;
        }
       
    }
}