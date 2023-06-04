# Factory Method

Consider the following example:
```cs
class Weapon {}
class Sword : Weapon {}
class Axe : Weapon {}

class Blacksmith
{
    Weapon MakeWeapon(string WeaponName)
    {
        if (WeaponName == "Sword")
        {
            return new Sword();
        }
        if (WeaponName == "Axe")
        {
            return new Axe();
        }
    }
}
```

If new `Weapon`s become available,
or existing `Weapon`s are removed,
the `Blacksmith` class must be modified.

In the Factory Pattern,
the object creation is moved to a separate class.
The sole purpose of this class is creating objects.
