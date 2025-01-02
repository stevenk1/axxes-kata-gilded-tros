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

    public static void IncrementQualityBy(this Item item, int value)
    {
        for (var i = 0; i < value; i++) IncrementQuality(item);
    }

    public static void DecrementQuality(this Item item)
    {
        if (item.Quality > 0) item.Quality--;
    }

    public static void DecrementQualityBy(this Item item, int value)
    {
        for (var i = 0; i < value; i++) DecrementQuality(item);
    }
}