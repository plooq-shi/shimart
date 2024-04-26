using System;
using System.Collections.Generic;
using System.Linq;
using ShiMartKata;
using Xunit;

namespace ShiMartTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var items = new List<Item> {
                new Item {Name = "Test", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Canned Beans", SellIn = -1, Quality = 80},
            };
            
            var app = new ShiMart(items);
                
            var days = 31;

            var testItem = items.Find(item => item.Name == "Test");
            var agedBrie = items.Find(item => item.Name == "Aged Brie");
            var cannedBeans = items.Find(item => item.Name == "Canned Beans");
            
            while (days > -31)
            {
                app.UpdateInventory();
                Assert.Equal(9, testItem.SellIn);
                Assert.Equal(19, items.First().Quality);
                days--;
            }
            
            
        }
    }
}
