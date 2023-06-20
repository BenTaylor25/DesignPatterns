
namespace Decorator
{
    interface ITea
    {
        public string GetInfo();
    }

    class Tea : ITea
    {
        public string GetInfo()
        {
            return "Tea";
        }
    }

    // Base Decorator
    abstract class TeaDecorator : ITea
    {
        private ITea tea;

        public TeaDecorator(ITea tea)
        {
            this.tea = tea;
        }

        public virtual string GetInfo()
        {
            return tea.GetInfo();
        }
    }

    // Concrete Decorator
    class Milk : TeaDecorator
    {
        public Milk(ITea tea) : base(tea) {}

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Milk";
        }
    }

    // Concrete Decorator
    class Sugar : TeaDecorator
    {
        public Sugar(ITea tea) : base(tea) {}

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Sugar";
        }
    }

    class Decorator
    {
        public static void Execute()
        {
            var blackTea = new Tea();
            Console.WriteLine(blackTea.GetInfo());

            var teaWithMilk = new Milk(new Tea());
            Console.WriteLine(teaWithMilk.GetInfo());

            var teaWithSugar = new Sugar(new Tea());
            Console.WriteLine(teaWithSugar.GetInfo());

            var teaWithMilkAndSugar = new Milk(
                new Sugar(new Tea())
            );
            Console.WriteLine(teaWithMilkAndSugar.GetInfo());
            // Tea, Sugar, Milk   (Sugar is applied first)
        }
    }
}