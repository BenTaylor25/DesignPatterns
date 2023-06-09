# Facade

The Facade Pattern offers a simplified
interface for dealing with specific
details of a library, framework,
or other complex set of classes.

Consider the following classes

```
class Kettle
    void BoilWater()
    Water GetWater()

class Cupboard
    Sugar GetSugar()
    Teabag GetTeabag()
    Coffee GetCoffee()

class Fridge
    Milk GetMilk()

class Cup
    void Add(Any)
```

In order to make a cup of Tea and
a cup of Coffee using these classes,
I would have to do something like

```cs
Cup teaCup = new();
Cup coffeeCup = new();

Cupboard cupboard = new();
teaCup.Add(cupboard.GetSugar());
teaCup.Add(cupboard.GetTeabag());
coffeeCup.Add(cupboard.GetSugar());
coffeeCup.Add(cupboard.GetCoffee());

Kettle kettle = new();
kettle.BoilWater();
teaCup.Add(kettle.GetWater());
coffeeCup.Add(kettle.GetWater());

Fridge fridge = new();
teaCup.Add(fridge.GetMilk());
coffeeCup.Add(fridge.GetMilk());
```

The above code relies on lots of
different parts from the set
of classes.  
This makes it difficult for the
client to use, and a nightmare
to refactor.

Instead, we could use a Facade
to put all of this logic in
one place.  
Anywhere the client needs
to make Tea or Coffee,
they can use the simple
Facade interface rather
than making it themselves.

```cs
Cup teaCup = HotDrinkFacade.MakeTea();
Cup coffeeCup = HotDrinkFacade.MakeCoffee();
```
