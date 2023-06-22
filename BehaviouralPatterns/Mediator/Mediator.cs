
namespace Mediator
{
    // Air Traffic Control
    interface IATCMediator
    {
        public void RegisterFlight(Flight flight);
        public void SendMessage(string message, Flight sender);
        public void RequestLanding(Flight lander);
    }

    class ControlTower : IATCMediator
    {
        private List<Flight> flights = new();

        public void RegisterFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public void SendMessage(string message, Flight sender)
        {
            string taggedMessage = $"{message} (from {sender.name})";

            foreach (var flight in flights)
            {
                if (flight != sender)
                {
                    flight.ReceiveMessage(taggedMessage);
                }
            }
        }

        public void RequestLanding(Flight lander)
        {
            foreach (var flight in flights)
            {
                if (flight != lander)
                {
                    flight.ReceiveMessage($"STANDBY {lander.name} is landing. (from ATC)");
                }
            }

            lander.ReceiveMessage("Clear to land (from ATC)");
        }
    }

    class Flight
    {
        public string name {get;}
        private IATCMediator mediator;

        public Flight(string name, IATCMediator mediator)
        {
            this.name = name;
            this.mediator = mediator;

            mediator.RegisterFlight(this);
        }

        public void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} received message: {message}");
        }

        public void RequestLanding()
        {
            mediator.RequestLanding(this);
        }
    }

    class Mediator
    {
        public static void Execute()
        {
            ControlTower tower = new();

            Flight flight1 = new("flight 1", tower);
            Flight flight2 = new("flight 2", tower);
            Flight flight3 = new("flight 3", tower);

            flight1.SendMessage("hi");

            Console.WriteLine();

            flight2.RequestLanding();
        }
    }
}