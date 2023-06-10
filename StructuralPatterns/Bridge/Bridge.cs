
namespace Bridge
{
    abstract class Vehicle
    {
        public IFuel fuelType;

        public Vehicle(IFuel fuel)
        {
            fuelType = fuel;
        }

        public void PrintInfo()
        {
            string fuelString = fuelType
                                    .GetType()
                                    .ToString();
            fuelString = fuelString
                            .Substring(fuelString.IndexOf('.') + 1);

            string vehicleString = this
                                    .GetType()
                                    .ToString();
            vehicleString = vehicleString
                            .Substring(vehicleString.IndexOf('.') + 1);

            Console.WriteLine($"{fuelString} {vehicleString}");
        }
    }
    class Car : Vehicle
    {
        public Car(IFuel fuel) : base(fuel) {}
    }
    class Motorcycle : Vehicle 
    {
        public Motorcycle(IFuel fuel) : base(fuel) {}
    }
    class Truck : Vehicle
    {
        public Truck(IFuel fuel) : base(fuel) {}
    }

    interface IFuel {}
    class Petrol : IFuel {}
    class Electric : IFuel {}
    class Diesel : IFuel {}

    class Bridge
    {
        public static void Execute()
        {
            var petrolCar = new Car(new Petrol());
            petrolCar.PrintInfo();   // Petrol Car

            var electricBike = new Motorcycle(new Electric());
            electricBike.PrintInfo();   // Electric Motorcycle

            var dieselTruck = new Truck(new Diesel());
            dieselTruck.PrintInfo();   // Diesel Truck
        }
    }
}