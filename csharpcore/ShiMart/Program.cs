using System;
using System.Collections.Generic;

namespace ShiMartKata
{
    public class Program
    {
        private const int Days = 31;

        public static void Main(string[] args)
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "Bananas", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Eggs", SellIn = 5, Quality = 7},
                new Item {Name = "Eggs", SellIn = 12, Quality = 5},
                new Item {Name = "Canned Beans", SellIn = 0, Quality = 80},
                new Item {Name = "Canned Beans", SellIn = -1, Quality = 80},
                
                // This Baked good does not work properly yet!
				new Item {Name = "Baked Sourdough Bread", SellIn = 3, Quality = 6},
				new Item {Name = "Baked Sourdough Bread", SellIn = 3, Quality = 20}
            };

            var app = new ShiMart(Items);


            for (var i = 0; i < (Days + 1); i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateInventory();
            }
        }
    }
}
