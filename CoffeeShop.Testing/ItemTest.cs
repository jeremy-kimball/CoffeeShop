namespace CoffeeShop.Testing
{
    public class ItemTest
    {
        [Fact]
        public void Item_Constructor_InitializesObject()
        {
            Item item1 = new Item("Item", 100);

            Assert.Equal("Item", item1.Name);
            Assert.Equal(100, item1.PriceInCents);
        }

        [Fact]
        public void Item_PriceInDollars_ReturnsPriceAsDouble()
        {
            Item item1 = new Item("Test", 150);
            Assert.Equal(1.5, item1.PriceInDollars());

            Item item2 = new Item("Test2", 255);
            Assert.Equal(2.55, item2.PriceInDollars());

            Item item3 = new Item("Test3", 1000);
            Assert.Equal(10, item3.PriceInDollars());

            Item item4 = new Item("Test4", 9999);
            Assert.Equal(99.99, item4.PriceInDollars());
        }

    }
}