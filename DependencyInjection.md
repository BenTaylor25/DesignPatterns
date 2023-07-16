
# Dependency Injection

Dependency Injection is an intimidating term
for a simple concept.

Here is an example of Dependency Injection:
```cs
interface IWeapon {}

class Sword : IWeapon {}
class Axe : IWeapon {}

class Fighter
{
    public readonly IWeapon Weapon { get; }

    public Fighter(IWeapon weapon)
    {
        Weapon = weapon;
    }
}
```
```cs
Fighter myFighter = new Fighter(new Sword());   // This is DI
```

A `Fighter` should be able to use any concrete weapon.  
Rather than depending on a concrete weapon, we can depend on
a common interface.  
This means that it is the responsibility of the class that
wishes to instantiate the `Fighter` to also instantiate a
concrete weapon and *inject* it in.

DI can also be done by setting a value on an existing object,
but this is generally ill-advised.

DI should not be used to reveal implementation details;
i.e. if class A should depend on concrete class B, B should
not be exposed to the caller of A.

Dependency Injection is a Design Pattern (not one of the big 23)
that allows for loose coupling of classes.  
It is closely related to the Dependency Inversion principle
*(see SOLID.md)*.
