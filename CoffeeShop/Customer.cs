using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Customer
    {
        public string Name;
        public List<Order> Orders;

        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public double TotalSpent()
        {
            double total = 0D;
            foreach(Order order in Orders)
            {
                total += order.Total();
            }
            return total;
        }

        public List<Item> ItemsOrdered()
        {
            List<Item> returnList = new List<Item>();
            foreach (Order order in Orders)
            {
                returnList.AddRange(order.Items);
            }
            return returnList.Distinct().ToList();
        }
    }
}
