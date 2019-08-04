using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void ConjuredItems()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Conjured Mana Cake", SellIn = 30, Quality = 50 },
                new Item {Name = "Conjured +5 Dexterity Vest", SellIn = 5, Quality = 30}};
            GildedRose app = new GildedRose(Items);

            for (int i = 0; i < 51; i++)
            {

                if (i == 1)
                {
                    Assert.AreEqual(29, Items[0].SellIn);
                    Assert.AreEqual(48, Items[0].Quality);

                    Assert.AreEqual(4, Items[1].SellIn);
                    Assert.AreEqual(28, Items[1].Quality);
                }
                else if (i == 5)
                {
                    Assert.AreEqual(0, Items[1].SellIn);
                    Assert.AreEqual(20, Items[1].Quality);
                }
                else if (i == 6)
                {
                    Assert.AreEqual(-1, Items[1].SellIn);
                    Assert.AreEqual(16, Items[1].Quality);
                }
                else if (i == 9)
                {
                    Assert.AreEqual(21, Items[0].SellIn);
                    Assert.AreEqual(32, Items[0].Quality);

                    Assert.AreEqual(-4, Items[1].SellIn);
                    Assert.AreEqual(4, Items[1].Quality);
                }
                else if (i == 10)
                {
                    Assert.AreEqual(20, Items[0].SellIn);
                    Assert.AreEqual(30, Items[0].Quality);

                    Assert.AreEqual(-5, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                else if (i == 24)
                {
                    Assert.AreEqual(6, Items[0].SellIn);
                    Assert.AreEqual(2, Items[0].Quality);
                }
                else if (i == 25)
                {
                    Assert.AreEqual(5, Items[0].SellIn);
                    Assert.AreEqual(0, Items[0].Quality);

                    Assert.AreEqual(-20, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                else if (i == 50)
                {
                    Assert.AreEqual(-20, Items[0].SellIn);
                    Assert.AreEqual(0, Items[0].Quality);

                    Assert.AreEqual(-45, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                app.UpdateQuality();
            }
        }
        [Test]
        public void ConcertTicketItems()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 5 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 0}};
            GildedRose app = new GildedRose(Items);

            for (int i = 0; i < 31; i++)
            {

                if (i == 1)
                {
                    Assert.AreEqual(10, Items[0].SellIn);
                    Assert.AreEqual(6, Items[0].Quality);

                    Assert.AreEqual(19, Items[1].SellIn);
                    Assert.AreEqual(1, Items[1].Quality);
                }
                else if (i == 2)
                {
                    Assert.AreEqual(9, Items[0].SellIn);
                    Assert.AreEqual(8, Items[0].Quality);
                }
                else if (i == 6)
                {
                    Assert.AreEqual(5, Items[0].SellIn);
                    Assert.AreEqual(16, Items[0].Quality);
                }
                else if (i == 7)
                {
                    Assert.AreEqual(4, Items[0].SellIn);
                    Assert.AreEqual(19, Items[0].Quality);
                }
                else if (i == 10)
                {
                    Assert.AreEqual(1, Items[0].SellIn);
                    Assert.AreEqual(28, Items[0].Quality);

                    Assert.AreEqual(10, Items[1].SellIn);
                    Assert.AreEqual(10, Items[1].Quality);
                }
                else if (i == 11)
                {
                    Assert.AreEqual(0, Items[0].SellIn);
                    Assert.AreEqual(31, Items[0].Quality);

                    Assert.AreEqual(9, Items[1].SellIn);
                    Assert.AreEqual(12, Items[1].Quality);
                }
                else if (i == 12)
                {
                    Assert.AreEqual(-1, Items[0].SellIn);
                    Assert.AreEqual(0, Items[0].Quality);

                    Assert.AreEqual(8, Items[1].SellIn);
                    Assert.AreEqual(14, Items[1].Quality);
                }
                else if (i == 15)
                {
                    Assert.AreEqual(5, Items[1].SellIn);
                    Assert.AreEqual(20, Items[1].Quality);
                }
                else if (i == 16)
                {
                    Assert.AreEqual(4, Items[1].SellIn);
                    Assert.AreEqual(23, Items[1].Quality);
                }
                else if (i == 20)
                {
                    Assert.AreEqual(0, Items[1].SellIn);
                    Assert.AreEqual(35, Items[1].Quality);
                }
                else if (i == 21)
                {
                    Assert.AreEqual(-10, Items[0].SellIn);
                    Assert.AreEqual(0, Items[0].Quality);

                    Assert.AreEqual(-1, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                else if (i == 30)
                {
                    Assert.AreEqual(-19, Items[0].SellIn);
                    Assert.AreEqual(0, Items[0].Quality);

                    Assert.AreEqual(-10, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                app.UpdateQuality();
            }
        }
        [Test]
        public void AgedBrieItems()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 20, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 20}};
            GildedRose app = new GildedRose(Items);

            for (int i = 0; i < 51; i++)
            {

                if (i == 1)
                {
                    Assert.AreEqual(19, Items[0].SellIn);
                    Assert.AreEqual(1, Items[0].Quality);

                    Assert.AreEqual(4, Items[1].SellIn);
                    Assert.AreEqual(21, Items[1].Quality);
                }
                else if (i == 5)
                {
                    Assert.AreEqual(0, Items[1].SellIn);
                    Assert.AreEqual(25, Items[1].Quality);
                }
                else if (i == 6)
                {
                    Assert.AreEqual(-1, Items[1].SellIn);
                    Assert.AreEqual(27, Items[1].Quality);
                }
                else if (i == 10)
                {
                    Assert.AreEqual(10, Items[0].SellIn);
                    Assert.AreEqual(10, Items[0].Quality);

                    Assert.AreEqual(-5, Items[1].SellIn);
                    Assert.AreEqual(35, Items[1].Quality);
                }
                else if (i == 17)
                {
                    Assert.AreEqual(-12, Items[1].SellIn);
                    Assert.AreEqual(49, Items[1].Quality);
                }
                else if (i == 20)
                {
                    Assert.AreEqual(0, Items[0].SellIn);
                    Assert.AreEqual(20, Items[0].Quality);

                    Assert.AreEqual(-15, Items[1].SellIn);
                    Assert.AreEqual(50, Items[1].Quality);
                }
                else if (i == 21)
                {
                    Assert.AreEqual(-1, Items[0].SellIn);
                    Assert.AreEqual(22, Items[0].Quality);

                    Assert.AreEqual(-16, Items[1].SellIn);
                    Assert.AreEqual(50, Items[1].Quality);
                }
                else if (i == 30)
                {
                    Assert.AreEqual(-10, Items[0].SellIn);
                    Assert.AreEqual(40, Items[0].Quality);
                }
                else if (i == 50)
                {
                    Assert.AreEqual(-30, Items[0].SellIn);
                    Assert.AreEqual(50, Items[0].Quality);

                    Assert.AreEqual(-45, Items[1].SellIn);
                    Assert.AreEqual(50, Items[1].Quality);
                }
                app.UpdateQuality();
            }
        }
        [Test]
        public void LegendaryItems()
        {
            IList<Item> Items = new List<Item> {new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }};
            GildedRose app = new GildedRose(Items);

            for (int i = 0; i < 51; i++)
            {

                if (i == 1)
                {
                    Assert.AreEqual(0, Items[0].SellIn);
                    Assert.AreEqual(80, Items[0].Quality);

                }
                else if (i == 25)
                {
                    Assert.AreEqual(0, Items[0].SellIn);
                    Assert.AreEqual(80, Items[0].Quality);
                }
                else if (i == 50)
                {
                    Assert.AreEqual(0, Items[0].SellIn);
                    Assert.AreEqual(80, Items[0].Quality);
                }
                app.UpdateQuality();
            }
        }

        [Test]
        public void RandomItems()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "foo", SellIn = 30, Quality = 50 },
                new Item {Name = "foo2", SellIn = 5, Quality = 30}};
            GildedRose app = new GildedRose(Items);

            for (int i = 0; i < 51; i++)
            {
                
                if (i == 1)
                {
                    Assert.AreEqual(29, Items[0].SellIn);
                    Assert.AreEqual(49, Items[0].Quality);

                    Assert.AreEqual(4, Items[1].SellIn);
                    Assert.AreEqual(29, Items[1].Quality);
                }
                else if (i == 5)
                {
                    Assert.AreEqual(0, Items[1].SellIn);
                    Assert.AreEqual(25, Items[1].Quality);
                }
                else if (i == 6)
                {
                    Assert.AreEqual(-1, Items[1].SellIn);
                    Assert.AreEqual(23, Items[1].Quality);
                }
                else if (i == 10)
                {
                    Assert.AreEqual(20, Items[0].SellIn);
                    Assert.AreEqual(40, Items[0].Quality);

                    Assert.AreEqual(-5, Items[1].SellIn);
                    Assert.AreEqual(15, Items[1].Quality);
                }
                else if (i == 17)
                {
                    Assert.AreEqual(-12, Items[1].SellIn);
                    Assert.AreEqual(1, Items[1].Quality);
                }
                else if (i == 17)
                {
                    Assert.AreEqual(12, Items[0].SellIn);
                    Assert.AreEqual(32, Items[0].Quality);

                    Assert.AreEqual(-13, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                else if (i == 30)
                {
                    Assert.AreEqual(0, Items[0].SellIn);
                    Assert.AreEqual(20, Items[0].Quality);

                    Assert.AreEqual(-25, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                else if (i == 31)
                {
                    Assert.AreEqual(-1, Items[0].SellIn);
                    Assert.AreEqual(18, Items[0].Quality);
                }
                else if (i == 39)
                {
                    Assert.AreEqual(-9, Items[0].SellIn);
                    Assert.AreEqual(2, Items[0].Quality);
                }
                else if (i == 40)
                {
                    Assert.AreEqual(-10, Items[0].SellIn);
                    Assert.AreEqual(0, Items[0].Quality);
                }
                else if (i == 50)
                {
                    Assert.AreEqual(-20, Items[0].SellIn);
                    Assert.AreEqual(0, Items[0].Quality);

                    Assert.AreEqual(-45, Items[1].SellIn);
                    Assert.AreEqual(0, Items[1].Quality);
                }
                app.UpdateQuality();
            }
        }
    }
}
