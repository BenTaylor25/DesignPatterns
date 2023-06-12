
namespace Proxy
{
    interface Payment
    {
        public void Pay(double amount);
    }

    class PaymentProcessor : Payment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Payment of £{amount}");
        }
    }

    class PaymentProxy : Payment
    {
        double totalSpent;
        // caching can be handled here too

        public void Pay(double amount)
        {
            if (totalSpent + amount < 100)
            {
                totalSpent += amount;
                Console.WriteLine($"Payment of £{amount.ToString("F2")}");
            }
            else
            {
                Console.WriteLine($"Payment failed: daily limit reached.");
            }
        }
    }

    class Proxy
    {
        public static void Execute()
        {
            var card = new PaymentProxy();

            card.Pay(15.50);
            card.Pay(50);
            card.Pay(20.20);
            card.Pay(35);   // daily limit fail
            card.Pay(5.50);
            card.Pay(12.75);   // daily limit fail
        }
    }
}