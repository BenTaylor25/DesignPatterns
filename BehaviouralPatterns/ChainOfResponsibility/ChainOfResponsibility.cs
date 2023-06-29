
namespace ChainOfResponsibility
{
    class Order
    {
        public string orderId { get; set; }
        public double value { get; set; }
        public string address { get; set; }

        public Order(string orderId, double value, string address)
        {
            this.orderId = orderId;
            this.value = value;
            this.address = address;
        }
    }

    interface OrderHandler
    {
        public void SetNextHandler(OrderHandler handler);
        public void Handle(Order order);
    }

    abstract class BaseHandler : OrderHandler
    {
        protected OrderHandler? next;

        public void SetNextHandler(OrderHandler handler)
        {
            next = handler;
        }

        public abstract void Handle(Order order);
    }

    class InventoryHandler : BaseHandler
    {
        // sample data
        List<string> validIds = new List<string>(){"abc", "def"};

        public override void Handle(Order order)
        {
            Console.WriteLine($"Checking inventory for order '{order.orderId}'");

            bool isAvailable = validIds.Contains(order.orderId);

            if (isAvailable)
            {
                Console.WriteLine("Inventory Check Successful");
                next?.Handle(order);
            }
            else
            {
                Console.WriteLine("Product is out of stock");
            }
        }
    }

    class PaymentHandler : BaseHandler
    {
        // sample data
        double userBalance = 100;

        public override void Handle(Order order)
        {
            Console.WriteLine($"Checking user balance for order '{order.orderId}'");

            bool isAffordable = order.value <= userBalance;

            if (isAffordable)
            {
                Console.WriteLine("Payment Successful");
                next?.Handle(order);
            }
            else
            {
                Console.WriteLine("Payment failed");
            }
        }
    }

    class ShippingHandler : BaseHandler
    {
        // sample data
        List<string> knownAddresses = new List<string>{"Oxford", "London"};

        public override void Handle(Order order)
        {
            Console.WriteLine($"Shipping order '{order.orderId}'");

            bool addressIsKnown = knownAddresses.Contains(order.address);

            if (addressIsKnown)
            {
                Console.WriteLine("Order has been shipped");
                next?.Handle(order);
            }
            else
            {
                Console.WriteLine("Shipping failed");
            }
        }
    }

    class ChainOfResponsibility
    {
        public static void Execute()
        {
            var fulfilOrder = new InventoryHandler();
            var _payment = new PaymentHandler();
            var _shipping = new ShippingHandler();
            fulfilOrder.SetNextHandler(_payment);
            _payment.SetNextHandler(_shipping);

            fulfilOrder.Handle(new Order("invalid", 50, "Oxford"));
            Console.WriteLine();
            fulfilOrder.Handle(new Order("abc", 5000, "Oxford"));
            Console.WriteLine();
            fulfilOrder.Handle(new Order("abc", 50, "invalid"));
            Console.WriteLine();
            fulfilOrder.Handle(new Order("abc", 50, "London"));
        }
    }
}