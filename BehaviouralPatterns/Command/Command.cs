
namespace Command
{
    class Calculator
    {
        double value = 0;
        List<ICommand<double>> commandHistory = new();

        public void ExecuteCommand(ICommand<double> command)
        {
            value = command.Execute(value);
            commandHistory.Add(command);
        }

        public void UndoCommand()
        {
            ICommand<double> command = commandHistory.Last();
            commandHistory.RemoveAt(commandHistory.Count - 1);
            value = command.Undo(value);
        }

        public void PrintVal()
        {
            Console.WriteLine(value);
        }
    }

    interface ICommand<T>
    {
        public T Execute(T currentValue);
        public T Undo(T currentValue);
    }

    class AddCommand : ICommand<double>
    {
        public double valueToAdd;

        public AddCommand(double valueToAdd)
        {
            this.valueToAdd = valueToAdd;
        }

        public double Execute(double currentValue)
        {
            return currentValue + valueToAdd;
        }

        public double Undo(double currentValue)
        {
            return currentValue - valueToAdd;
        }
    }

    class MulCommand : ICommand<double>
    {
        public double valueToMul;

        public MulCommand(double valueToMul)
        {
            this.valueToMul = valueToMul;
        }

        public double Execute(double currentValue)
        {
            return currentValue * valueToMul;
        }

        public double Undo(double currentValue)
        {
            return currentValue / valueToMul;
        }
    }

    class Command
    {
        public static void Execute()
        {
            Calculator calc = new();

            calc.ExecuteCommand(new AddCommand(5));
            calc.ExecuteCommand(new AddCommand(10));

            calc.PrintVal();   // 15

            calc.UndoCommand();

            calc.PrintVal();   // 5

            calc.ExecuteCommand(new MulCommand(4));

            calc.PrintVal();   // 20
        }
    }
}