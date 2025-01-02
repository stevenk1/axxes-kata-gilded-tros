﻿using System;
using System.Collections.Generic;

namespace GildedTros.App;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> Items = new List<Item>
        {
            new() { Name = "Ring of Cleansening Code", SellIn = 10, Quality = 20 },
            new() { Name = "Good Wine", SellIn = 2, Quality = 0 },
            new() { Name = "Elixir of the SOLID", SellIn = 5, Quality = 7 },
            new() { Name = "B-DAWG Keychain", SellIn = 0, Quality = 80 },
            new() { Name = "B-DAWG Keychain", SellIn = -1, Quality = 80 },
            new() { Name = "Backstage passes for Re:factor", SellIn = 15, Quality = 20 },
            new() { Name = "Backstage passes for Re:factor", SellIn = 10, Quality = 49 },
            new() { Name = "Backstage passes for HAXX", SellIn = 5, Quality = 49 },
            new() { Name = "Duplicate Code", SellIn = 3, Quality = 6 },
            new() { Name = "Long Methods", SellIn = 3, Quality = 6 },
            new() { Name = "Ugly Variable Names", SellIn = 3, Quality = 6 }
        };

        var app = new GildedTros(Items);


        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < Items.Count; j++)
                Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}