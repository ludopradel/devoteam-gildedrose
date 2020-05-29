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
                switch (item.Name)
                {
                    case "Aged Brie":
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;

                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }

                        }

                        break;
                    default:
                        if (item.Quality > 0)
                        {

                            item.Quality = item.Quality - 1;

                        }

                        break;
                }


                item.SellIn = item.SellIn - 1;


                if (item.SellIn < 0)
                {
                    if (item.Name == "Aged Brie")
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                    else
                    {
                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                        else
                        {
                            if (item.Quality > 0)
                            {

                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
