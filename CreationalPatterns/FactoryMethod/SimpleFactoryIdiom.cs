using System;

namespace SimpleFactoryIdiom
{
    class Weapon {}
    class Sword : Weapon {}
    class Axe : Weapon {}

    class WeaponFactory
    {
        public Weapon CreateWeapon(string WeaponType)
        {
            if (WeaponType == "Sword")
            {
                return new Sword();
            }
            if (WeaponType == "Axe")
            {
                return new Axe();
            }
            return new Weapon();
        }
    }

    class Blacksmith {
        public Weapon MakeWeapon(string WeaponType)
        {
            WeaponFactory Factory = new();
            Weapon NewWeapon = Factory.CreateWeapon(WeaponType);

            /// Blacksmith-specific logic
            // NewWeapon.Polish();

            return NewWeapon;
        }
    }

    class SimpleFactoryIdiom
    {
        public static void Execute()
        {
            Console.WriteLine("Simple Factory Idiom");
            Console.WriteLine("--------------");
            Console.WriteLine();

            Blacksmith MyBlacksmith = new();

            Weapon MySword = MyBlacksmith.MakeWeapon("Sword");
            Console.WriteLine(MySword.GetType());

            Weapon MyAxe = MyBlacksmith.MakeWeapon("Axe");
            Console.WriteLine(MyAxe.GetType());
        }
    }
}
