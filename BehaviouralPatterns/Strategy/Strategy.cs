
namespace Strategy
{
    class Numbers
    {
        int[] numbers;

        public Numbers(params int[] numbers)
        {
            this.numbers = numbers;
        }

        public void PrintNumbers()
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
        }

        public void Sort(ISorter sorter)
        {
            sorter.Sort(numbers);
        }
    }

    interface ISorter
    {
        public void Sort(int[] numbers);
    }

    class BubbleSort : ISorter
    {
        public void Sort(int[] numbers)
        {
            bool hasSwapped;
            do
            {
                hasSwapped = false;
                for (int i = 0; i < numbers.Count() - 1; i++)
                {
                    if (numbers[i] > numbers[i+1])
                    {
                        hasSwapped = true;
                        int temp = numbers[i];
                        numbers[i] = numbers[i+1];
                        numbers[i+1] = temp;
                    }
                }
            } while (hasSwapped);
        }
    }

    class CSharpSort : ISorter
    {
        public void Sort(int[] numbers)
        {
            Array.Sort(numbers);
        }
    }


    class Strategy
    {
        public static void Execute()
        {
            Numbers n = new(1, 5, 3, 4, 5, 1);
            n.PrintNumbers();
            n.Sort(new BubbleSort());
            n.PrintNumbers();

            Console.WriteLine();

            Numbers n2 = new(1, 5, 3, 4, 5, 1);
            n2.PrintNumbers();
            n2.Sort(new CSharpSort());
            n2.PrintNumbers();
        }
    }
}