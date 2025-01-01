using GildedTros.App.Strategies;

namespace GildedTros.App;

public class ItemQualityUpdateStrategyFactory
{
    public IItemQualityUpdateStrategy Create(Item item)
    {
        return item.Name switch
        {
            "Good Wine" => new GoodWineStrategy(),
            "Ring of Cleansening Code" or "Elixir of the SOLID" => new DefaultStrategy(),
            "B-DAWG Keychain" => new LegendaryStrategy(),
            "Backstage passes for Re:factor" or "Backstage passes for HAXX" => new BackstagePassesStrategy(),
            _ => new DefaultStrategy()
        };
    }
}