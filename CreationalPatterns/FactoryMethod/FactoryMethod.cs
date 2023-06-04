using System;

namespace FactoryMethod
{
    interface Weapon {}
    class Sword : Weapon {}
    class Axe : Weapon {}
    class Bow : Weapon {}

    interface WeaponCreator
    {
        public Weapon FactoryMethod();
    }

    class RandWeaponCreator : WeaponCreator
    {
        Random r = new();

        public Weapon FactoryMethod()
        {
            switch (r.Next(0, 3))
            {
                case 0:
                    return new Sword();
                case 1:
                    return new Axe();
                case 2:
                    return new Bow();

                // to please compiler
                default:
                    return new Sword();
            }
        }
    }

    class SeqWeaponCreator : WeaponCreator
    {
        private int state;

        public SeqWeaponCreator()
        {
            state = -1;
        }

        public Weapon FactoryMethod()
        {
            state = (state + 1) % 3;

            switch (state)
            {
                case 0:
                    return new Sword();
                case 1:
                    return new Axe();
                case 2:
                    return new Bow();

                // to please compiler
                default:
                    return new Sword();
            }
        }
    }

    class FactoryMethod
    {
        public static void Execute()
        {
            Console.WriteLine("Factory Method");
            Console.WriteLine("--------------");
            Console.WriteLine();

            Console.WriteLine("Random");
            Console.WriteLine("------");
            WeaponCreator rwc = new RandWeaponCreator();
            Console.WriteLine(rwc.FactoryMethod().GetType());
            Console.WriteLine(rwc.FactoryMethod().GetType());
            Console.WriteLine(rwc.FactoryMethod().GetType());
            Console.WriteLine(rwc.FactoryMethod().GetType());

            Console.WriteLine();

            Console.WriteLine("Sequential");
            Console.WriteLine("----------");
            WeaponCreator swc = new SeqWeaponCreator();
            Console.WriteLine(swc.FactoryMethod().GetType());
            Console.WriteLine(swc.FactoryMethod().GetType());
            Console.WriteLine(swc.FactoryMethod().GetType());
            Console.WriteLine(swc.FactoryMethod().GetType());
        }
    }
}

