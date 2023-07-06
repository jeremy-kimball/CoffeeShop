using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Testing
{
    public class OrderTest
    {
        [Fact]
        public void Order_Constructor_InitializesObject()
        {
            Order order1 = new Order();
            Assert.Equal(new List<Item>(), order1.ItemList);
        }
        [Fact]
        public void Order_AddItem_AddToListProperty()
        {
            Order order1 = new Order();
            Item item1 = new Item("Item 1", 100);

            order1.AddItem(item1);

            Assert.Equal(item1, order1.ItemList[0]);
        }
        [Fact]
        public void Order_Items_ReturnsItemsList()
        {
            Order order1 = new Order();
            Item item1 = new Item("Item 1", 100);
            Item item2 = new Item("Item 2", 200);
            Item item3 = new Item("Item 3", 300);

            order1.AddItem(item1);
            order1.AddItem(item2);
            order1.AddItem(item3);

            List<Item> testList = new List<Item> { item1 , item2, item3 };

            Assert.Equal(testList, order1.Items());
        }
        [Fact]
        public void Order_Total_ReturnsDoubleTotalOfItemList()
        {
            Order order1 = new Order();
            Item item1 = new Item("Item 1", 100);
            Item item2 = new Item("Item 2", 200);
            Item item3 = new Item("Item 3", 300);
            
            order1.AddItem(item1);
            order1.AddItem(item2);
            order1.AddItem(item3);

            Assert.Equal(6, order1.Total());
        }
    }
}
