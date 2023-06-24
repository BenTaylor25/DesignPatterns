
namespace Memento
{
    class ShoppingCart
    {
        private List<string> items;

        public ShoppingCart()
        {
            items = new();
        }

        public void Add(string item)
        {
            items.Add(item);
        }

        public void PrintItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(items[i]);
            }
            Console.WriteLine();
        }

        public ShoppingCartMemento Save()
        {
            return new ShoppingCartMemento(items);
        }

        public void Restore(ShoppingCartMemento memento)
        {
            items = memento.GetState();
        }
    }

    class ShoppingCartMemento
    {
        private List<string> state;

        public ShoppingCartMemento(List<string> state)
        {
            this.state = new List<string>(state);
        }

        public List<string> GetState()
        {
            return state;
        }
    }

    class History
    {
        private List<ShoppingCartMemento> mementos;

        public History()
        {
            mementos = new List<ShoppingCartMemento>();
        }

        public void AddMemento(ShoppingCartMemento memento)
        {
            mementos.Add(memento);
        }

        public ShoppingCartMemento GetMemento(int ind)
        {
            return mementos[ind];
        }
    }

    class Memento
    {
        public static void Execute()
        {
            ShoppingCart shoppingCart = new();
            shoppingCart.Add("Bread");

            History history = new();
            history.AddMemento(shoppingCart.Save());

            shoppingCart.Add("Milk");
            shoppingCart.Add("Cheese");
            shoppingCart.PrintItems();

            shoppingCart.Restore(history.GetMemento(0));
            shoppingCart.PrintItems();
        }
    }
}