using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace ShiMartKata
{
    public class ShiMart
    {
        IList<Item> Items;
        public ShiMart(IList<Item> Items)
        {
            this.Items = Items;
        }

        private void UpdateSellIn(Item item)
        {
            // "Canned Beans", being a non-perishable, never has to be sold or decreases in Quality.
            if (item.Name != "Canned Beans")
            {
                item.SellIn--;
            }
        }
        
        private void UpdateQuality(Item item)
        {
            // Do the instructions mention that the Aged Brie doubles in rate after past the sell in date?
            int updateQuantity = item.SellIn < 0 ? 2 : 1;
            
            switch (item.Name)
            {
                case "Canned Beans":
                    break;
                case "Aged Brie":
                    if (item.Quality < 50) item.Quality+= updateQuantity;
                    if (item.Quality > 50) item.Quality = 50;
                    break;
                default:
                    if (item.Name.Contains("Baked")) { updateQuantity *= 2; }
                    if(item.Quality > 0) item.Quality-= updateQuantity;
                    if (item.Quality < 0) item.Quality = 0;
                    break;
            }
            
        }

        public void UpdateInventory()
        {
            foreach (var item in Items)
            {
                UpdateSellIn(item);

                UpdateQuality(item);
                
            }
        }
    }
}
