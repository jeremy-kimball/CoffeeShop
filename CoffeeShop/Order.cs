using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Order
    {
        public List<Item> ItemList;

        public Order()
        {
            ItemList = new List<Item>();
        }

        public void AddItem(Item item)
        {
            ItemList.Add(item);
        }

        public List<Item> Items()
        {
            return ItemList;
        }

        public double Total()
        {
            double total = 0D;
            foreach(Item item in ItemList)
            {
                total += item.PriceInDollars();
            }
            return total;
        }
    }

}
