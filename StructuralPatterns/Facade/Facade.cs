
namespace Facade
{
    interface IDrinkContent {}
    class Water : IDrinkContent {}
    class Sugar : IDrinkContent {}
    class Teabag : IDrinkContent {}
    class Coffee : IDrinkContent {}
    class Milk : IDrinkContent {}

    class Kettle
    {
        public void BoilWater() {}
        public Water GetWater() { return new Water(); }
    }
    class Cupboard
    {
        public Sugar GetSugar() { return new Sugar(); }
        public Teabag GetTeabag() { return new Teabag(); }
        public Coffee GetCoffee() { return new Coffee(); }
    }
    class Fridge
    {
        public Milk GetMilk() { return new Milk(); }
    }
    class Cup
    {
        public List<IDrinkContent> contents;

        public Cup()
        {
            contents = new List<IDrinkContent>();
        }

        public void Add(IDrinkContent item)
        {
            contents.Add(item);
        }
    }

    class HotDrinkFacade
    {
        public static Cup MakeTea()
        {
            Cup teaCup = new();
            
            Cupboard cupboard = new();
            teaCup.Add(cupboard.GetTeabag());
            teaCup.Add(cupboard.GetSugar());

            Kettle kettle = new();
            kettle.BoilWater();
            teaCup.Add(kettle.GetWater());

            Fridge fridge = new();
            teaCup.Add(fridge.GetMilk());

            return teaCup;
        }

        public static Cup MakeCoffee()
        {
            Cup coffeeCup = new();
            
            Cupboard cupboard = new();
            coffeeCup.Add(cupboard.GetCoffee());
            coffeeCup.Add(cupboard.GetSugar());

            Kettle kettle = new();
            kettle.BoilWater();
            coffeeCup.Add(kettle.GetWater());

            Fridge fridge = new();
            coffeeCup.Add(fridge.GetMilk());

            return coffeeCup;
        }

        public static void PrintContents(Cup cup)
        {
            foreach (IDrinkContent item in cup.contents)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }

    class Facade
    {
        public static void Execute()
        {
            Cup tea = HotDrinkFacade.MakeTea();
            HotDrinkFacade.PrintContents(tea);

            Console.WriteLine();

            Cup coffee = HotDrinkFacade.MakeCoffee();
            HotDrinkFacade.PrintContents(coffee);
        }
    }
}