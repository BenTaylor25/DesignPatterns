
namespace Iterator
{
    interface Iterable<T>
    {
        Iter<T> GetIter();
    }

    interface Iter<T>
    {
        bool HasNext();
        T GetNext();
        bool AtStart();
    }

    class Collection : Iterable<int>
    {
        private int[] items;

        public Collection(params int[] items)
        {
            this.items = items;
        }

        public Iter<int> GetIter()
        {
            return new MyIter(items);
        }

        private class MyIter : Iter<int>
        {
            private int[] items;
            private int ind = 0;

            public MyIter(int[] items)
            {
                this.items = items;
            }

            public bool HasNext()
            {
                return ind < items.Length;
            }

            public int GetNext()
            {
                if (!this.HasNext())
                {
                    Console.WriteLine("End of Iterator");
                    return 0;
                }
                return items[ind++];
            }

            public bool AtStart()
            {
                return ind == 0;
            }
        }
    }

    class Iterator
    {
        public static void Execute()
        {
            Collection myCol = new(5,3,1,4,6);

            Iter<int> it = myCol.GetIter();

            // 5, 3, 1, 4, 6
            while (it.HasNext())
            {
                if (!it.AtStart())
                {
                    Console.Write(", ");
                }
                Console.Write(it.GetNext());
            }
            Console.WriteLine();

            Console.WriteLine();

            // End of Iterator
            // 0
            Console.WriteLine(it.GetNext());
        }
    }
}