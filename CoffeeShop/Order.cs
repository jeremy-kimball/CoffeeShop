using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Order
    {
        public List<Item> Items;

        public Order()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public double Total()
        {
            double total = 0D;
            foreach(Item item in Items)
            {
                total += item.PriceInDollars();
            }
            return total;
        }
    }

}
