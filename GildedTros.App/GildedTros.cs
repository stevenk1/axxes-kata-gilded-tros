using System.Collections.Generic;
using GildedTros.App.Factories;

namespace GildedTros.App;

public class GildedTros
{
    private readonly IList<Item> Items;

    public GildedTros(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            var strategy = new ItemQualityUpdateStrategyFactory().Create(item);
            strategy.UpdateQuality(item);
        }
    }
}