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

Simple Factory Idiom.

---

### Simple Factory Idiom != Factory Method

---

The Factory Method Pattern is where we have one or more factories
for instantiating Objects.  
All of these factories are unified by an interface.

Example:
```
[Data]
- Animal (interface)
    - Dog
    - Cat
    - Duck

[Factories]
- AnimalFactory (interface)
    - RandomAnimalFactory
    - SequentialAnimalFactory
    - BalancedRandomAnimalFactory
```

`RandomAnimalFactory`, `SequentialAnimalFactory`,
and `BalancedRandomAnimalFactory` represent different ways
of creating Animal Subclass Objects.

[  
`RandomAnimalFactory` - Random  
`SequentialAnimalFactory` - Dog, Cat, Duck, (repeat)  
`BalancedRandomAnimalFactory` - Random but ignore most common so far.  
]

Classes that need to create Objects -
but don't care about how -
can use the `AnimalFactory` interface.
