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
            for (var i = 0; i < Items.Count; i++)
            {
                if (IsItemLegendary(Items[i].Name))
                {
                    Items[i].Quality = 80;
                    continue;
                }                

                int degradeVal = -1;

                if (Items[i].Name.Contains("Aged Brie"))
                    degradeVal = 1;
                else if (Items[i].Name.Contains("Backstage passes"))
                    degradeVal = GetDegradeValueOfBackstagePass(Items[i]);
                else if (Items[i].Name.Contains("Conjured"))
                    degradeVal = -2;

                if (Items[i].SellIn <= 0)
                    degradeVal = 2 * degradeVal;

                Items[i].Quality = SetQualityByDegVal(Items[i].Quality, degradeVal);
                Items[i].SellIn -= 1;

            }
        }
        private int SetQualityByDegVal(int quality, int degradeVal)
        {
            quality += degradeVal;

            if (quality >= 50)
                return 50;
            else if (quality <= 0)
                return 0;

            return quality;
        }
        private int GetDegradeValueOfBackstagePass(Item item)
        {
            int val = 1;

            if (item.SellIn <= 0)
                val = -50; 
            else if (item.SellIn <= 5)
                val = 3;
            else if (item.SellIn <= 10)
                val = 2;

            return val;
        }

        private bool IsItemLegendary(string itemName)
        {
            if (itemName.Contains("Sulfuras"))
                return true;
            else
                return false;
        }

        public void UpdateQualityOld()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
