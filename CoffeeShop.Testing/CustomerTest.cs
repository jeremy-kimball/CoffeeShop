using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Testing
{
    public class CustomerTest
    {
        [Fact]
        public void Customer_Constructor_InitializesObject()
        {
            Customer jeremy = new Customer("Jeremy");

            Assert.Equal("Jeremy", jeremy.Name);
            Assert.Equal(new List<Order>(), jeremy.Orders);
        }
        [Fact]
        public void Customer_AddOrder_AddsOrderToOrderListProperty()
        {
            Customer jeremy = new Customer("Jeremy");
            Item item1 = new Item("Item 1", 100);
            Order order1 = new Order();
            order1.AddItem(item1);

            jeremy.AddOrder(order1);

            Assert.Equal(order1, jeremy.Orders[0]);

        }
        [Fact]
        public void Customer_TotalSpent_ReturnDoubleTotalOfAllOrders()
        {
            Customer jeremy = new Customer("Jeremy");
            Item item1 = new Item("Item 1", 100);
            Item item2 = new Item("Item 2", 200);
            Order order1 = new Order();
            Order order2 = new Order();
            order1.AddItem(item1);
            order2.AddItem(item2);
            jeremy.AddOrder(order1);
            jeremy.AddOrder(order2);

            Assert.Equal(3, jeremy.TotalSpent());
        }
        [Fact]
        public void Customer_ItemsOrdered_ReturnUniqueItemList()
        {
            Customer jeremy = new Customer("Jeremy");
            Item item1 = new Item("Item 1", 100);
            Item item2 = new Item("Item 2", 200);
            Order order1 = new Order();
            Order order2 = new Order();
            order1.AddItem(item1);
            order2.AddItem(item2);
            order2.AddItem(item1);
            jeremy.AddOrder(order1);
            jeremy.AddOrder(order2);
            Assert.Equal(2, jeremy.ItemsOrdered().Count());
        }
    }
}
