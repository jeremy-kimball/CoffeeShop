using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Item
    {
        public string Name;
        public int PriceInCents;

        public Item(string name, int priceInCents)
        {
            Name = name;
            PriceInCents = priceInCents;
        }

        public double PriceInDollars()
        {
            return (Convert.ToDouble(PriceInCents) / 100);
        }
    }
}
