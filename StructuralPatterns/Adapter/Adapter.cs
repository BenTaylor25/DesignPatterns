
namespace Adapter
{
    interface IPaymentProcessor
    {
        public void ProcessPayment(double amount);
    }

    class ThirdPartyPaymentProcessor   // does not implement interface
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"third party is processing payment of £{amount.ToString("F2")}");
        }
    }

    class PaymentProcessorAdapter : IPaymentProcessor
    {
        private ThirdPartyPaymentProcessor tppp;

        public PaymentProcessorAdapter(ThirdPartyPaymentProcessor tppp)
        {
            this.tppp = tppp;
        }

        public void ProcessPayment(double amount)
        {
            tppp.MakePayment(amount);
        }
    }

    class Adapter
    {
        public static void Execute()
        {
            IPaymentProcessor pp = new PaymentProcessorAdapter(
                new ThirdPartyPaymentProcessor()
            );

            pp.ProcessPayment(5.30);
        }
    }
}