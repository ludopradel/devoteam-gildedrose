using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    continue;
                }

                item.SellIn = item.SellIn - 1;

                switch (item.Name)
                {
                    case "Aged Brie":
                        IncreaseQuality(item);
                        if (item.SellIn < 0)
                            IncreaseQuality(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        IncreaseQuality(item);
                        if (item.SellIn < 10)
                        {
                            IncreaseQuality(item);
                        }

                        if (item.SellIn < 5)
                        {
                            IncreaseQuality(item);

                        }
                        if (item.SellIn < 0)
                            item.Quality = 0;
                        break;
                    default:
                        if (item.Quality > 0)
                        {
                            item.Quality = item.Quality - 1;
                            if (item.SellIn < 0)
                                item.Quality = item.Quality - 1;
                        }
                        break;
                }
            }
        }

        private static void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}
