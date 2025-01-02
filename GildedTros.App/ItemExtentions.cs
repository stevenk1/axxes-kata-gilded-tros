namespace GildedTros.App;

public static class ItemExtentions
{
    public static bool IsExpired(this Item item)
    {
        return item.SellIn < 0;
    }

    public static void IncrementQuality(this Item item)
    {
        if (item.Quality < 50) item.Quality++;
    }

    public static void DecrementQuality(this Item item)
    {
        if (item.Quality > 0) item.Quality--;
    }
}