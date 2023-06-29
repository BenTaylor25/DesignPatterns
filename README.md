# Design Patterns

A design pattern is structure
that can be generalised and
reused in a large number of
projects.

*Design Patterns* typically
refers to the Elements of
Reusable Object-Oriented Software
book of 23 design patterns by the
"Gang of Four" (Erich Gamma, Richard
Helm, Ralph Johnson, John Vlissides).

This project is my notes while
learning the "big 23" Design Patterns.
For each design pattern, I have a
markdown file for notes, and a
practical demo written in C#.
I have made a very simple CLI to
execute the various demo files.  
Run the CLI with `dotnet run`.

The big 23 Design Patterns are
split into 3 categories:
- Creational
- Structural
- Behavioural

---
---

# Creational Patterns

Creational Design Patterns are patterns
that are responsible for Object creation.

The Creational Patterns are:
- Abstract Factory
- Builder
- Factory Method
- Prototype
- Singleton

## Abstract Factory
(see Factory Method first)

The Abstract Factory pattern should be used
when you have families of related objects.  
That is, each factory is now able to create
different objects, and the client chooses
which one the factory should create.

e.g.
Intel and AMD are both able to create
CPUs *and* GPUs.
The client has access to a Manufacturer
(Intel or AMD), and chooses whether it
wants to create a CPU or GPU.
(Both concrete manufacturers are able
to do this).

## Builder
When a class has a large number of optional
fields, use the Builder pattern to avoid
using `null` in the constructor call.

```cs
Person person = new Person()
    .SetName("Ben")
    .SetAge(19)
    .Build();
```

rather than

```cs
Person person = new Person("Ben", null, 19, null, null);
```

## Factory Method
When an Object needs to instantiate an
unknown Concrete Type (of a known
Interface), the main Object should not
handle the logic that decides which
Concrete Type is created. Instead,
this should be handled by a Factory.

If there are multiple ways to decide
which Concrete Type should be
instantiated (i.e. a class has multiple
factories), we can use an interface
with a Factory Method.  
The main Object (that needs to create
an object) can depend on the interface
so that it can be given any Factory
(i.e. any way of deciding which object
to instantiate).

e.g.
Blacksmith depends on interface
`IWeaponCreator`, so that it can use
`RandomWeaponCreator` or
`SequentialWeaponCreator` interchangeably
depending on what it has been given.

## Prototype
Prototype is object Cloning.  
The constructor should accept
an object of it's own class to
clone all values onto the new
object.

```cs
Car car1 = new Car("black", "fiesta");

// this is a reference copy
Car alsoCar1 = car1;

// this should create a clone
// (if the Prototype pattern has been applied)
Car car2 = new Car(car1);
```

## Singleton
The Singleton Pattern ensures that a class
can only have one instance.

e.g.
For a simulation / game, you probably only
want to have one instance of the `World`
class.

---
---

# Structural Patterns

Structural Patterns are patterns that
define how classes are related.

The Structural Patterns are:
- Adapter
- Bridge
- Composite
- Decorator
- Facade
- Flyweight
- Proxy

## Adapter

The adapter pattern is used to
make unchangeable classes
compatible with a new interface.

```cs
interface IStudent {}

class UniversityStudent {}
class CollegeStudent : IStudent {}
```

If the `UniversityStudent` class cannot
be modified (either because we don't have
access to it, or it would break the system),
we can create an Adapter in order to make
it compatible with `IStudent`.

## Bridge

When you have classes with multiple dimensions
of variability  
e.g.
```
PetrolCar     DieselCar     ElectricCar
PetrolBike    DieselBike    ElectricBike
PetrolTruck   DieselTruck   ElectricTruck
```
you should use composition to capture one of
the dimensions to avoid poor scaling.

```cs
var petrolCar = new Car(new Petrol());
```

## Composite

The Composite Pattern says that containers
should be able to describe/summarise their
contents.

e.g.
```
Box {
    Box {
        Box {
            Product (£8)
        }
        Product (£7)
    }
    Product (£5)
    Product (£2)
}
```
`Box`es should be able to get the total
cost of items they contain, and this
should work regardless of nesting levels.

## Decorator

The Decorator Pattern uses nested composition
to allow objects to be modified by wrappers.

```cs
class Milk : TeaDecorator
{
    public Milk(ITea tea) : base(tea) {}

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Milk";
    }
}

var teaWithMilk = new Milk(new Tea());
```

The pattern can be nested to bring lots
of behaviours together.

## Facade

The Facade Pattern takes a group of classes
(usually from a library, or segregated part
of the codebase), and provides a single point
of interaction, which means clients do not
need to interact with the underlying classes.

```cs
Cup teaCup = HotDrinkFacade.MakeTea();

// Rather than

Cup teaCup = new();
Cupboard cupboard = new();
Kettle kettle = new();
Fridge fridge = new();

teaCup.Add(cupboard.GetSugar());
teaCup.Add(cupboard.GetTeabag());
kettle.BoilWater();
teaCup.Add(kettle.GetWater());
teaCup.Add(fridge.GetMilk());
```

## Flyweight

The Flyweight Pattern is designed
to reduce memory consumption when
a large number of objects are
created from a single class.

When a frequently-instantiated
class has several immutable attributes
whose value should be shared by
multiple objects, the shared data
can be abstracted out into a
flyweight object and shared by
the objects using references.

## Proxy

The Proxy Pattern sets up an
intermediate step in the
interaction between objects.
(Much like internet proxy servers).

This can restrict access of particular
objects, but is perhaps more useful
for caching.  
e.g. set up a proxy to read from a
database so that you can get the value
from the proxy multiple times with
only one database call.

---
---

# Behavioural Patterns

Behavioural Patterns are patterns that
define how objects communicate.

The Behavioural Patterns are:
- Chain of Responsibility
- Command
- Interpreter
- Iterator
- Mediator
- Memento
- Observer
- State
- Strategy
- Template Method
- Visitor
