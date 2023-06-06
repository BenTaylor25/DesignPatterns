
namespace Composite
{
    interface ICompositeItem
    {
        public int PriceSum();
    }

    class Box : ICompositeItem
    {
        List<ICompositeItem> items;

        public Box()
        {
            items = new List<ICompositeItem>();
        }

        public void AddItem(ICompositeItem item)
        {
            items.Add(item);
        }

        public int PriceSum()
        {
            int sum = 0;
            foreach (var item in items)
            {
                sum += item.PriceSum();
            }
            return sum;
        }
    }

    class Product : ICompositeItem
    {
        int price;

        public Product(int price)
        {
            this.price = price;
        }

        public int PriceSum()
        {
            return price;
        }
    }

    class Composite
    {
        public static void Execute()
        {
            Box outerBox = new Box();
            Box middleBox = new Box();
            Box innerBox = new Box();

            outerBox.AddItem(middleBox);
            middleBox.AddItem(innerBox);

            innerBox.AddItem(new Product(1));

            middleBox.AddItem(new Product(2));
            middleBox.AddItem(new Product(3));

            outerBox.AddItem(new Product(4));
            outerBox.AddItem(new Product(5));

            Console.WriteLine($"Inner Box Sum:  {innerBox.PriceSum()}");    // 1
            Console.WriteLine($"Middle Box Sum: {middleBox.PriceSum()}");   // 6
            Console.WriteLine($"Outer Box Sum:  {outerBox.PriceSum()}");    // 15
        }
    }
}
