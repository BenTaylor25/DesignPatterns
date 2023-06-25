
namespace TemplateMethod
{
    abstract class Coffee
    {
        // Template Method
        public void MakeCoffee()
        {
            BoilWater();
            BrewCoffee();
            PourInCup();
            AddExtras();
        }

        protected virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void BrewCoffee();

        protected virtual void PourInCup()
        {
            Console.WriteLine("Pouring water in cup");
        }

        protected virtual void AddExtras() {}
    }

    class Espresso : Coffee
    {
        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing espresso");
        }
    }

    class Latte : Coffee
    {
        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing latte");
        }

        protected override void AddExtras()
        {
            Console.WriteLine("Adding milk");
        }
    }

    class TemplateMethod
    {
        public static void Execute()
        {
            Coffee espresso = new Espresso();
            espresso.MakeCoffee();

            Console.WriteLine();

            Coffee latte = new Latte();
            latte.MakeCoffee();
        }
    }
}