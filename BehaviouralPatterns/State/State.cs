
namespace State
{
    class VendingMachine
    {
        public IBalance balanceState = new Zero();

        public void AddFiftyPence()
        {
            balanceState.AddFiftyPence(this);
        }
    }

    interface IBalance
    {
        public void AddFiftyPence(VendingMachine vm);
    }
    class Zero : IBalance
    {
        public void AddFiftyPence(VendingMachine vm)
        {
            Console.WriteLine("50p added to the machine");
            vm.balanceState = new FiftyPence();
        }
    }
    class FiftyPence : IBalance
    {
        public void AddFiftyPence(VendingMachine vm)
        {
            Console.WriteLine("50p added to the machine | you can now buy a drink");
            vm.balanceState = new OnePound();
        }
    }
    class OnePound : IBalance
    {
        public void AddFiftyPence(VendingMachine vm)
        {
            Console.WriteLine("50p fell through the machine | select a drink");
        }
    }

    class State
    {
        public static void Execute()
        {
            VendingMachine vm = new();

            vm.AddFiftyPence();
            vm.AddFiftyPence();
            vm.AddFiftyPence();
        }
    }
}