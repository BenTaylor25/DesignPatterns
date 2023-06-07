# Prototype

The Prototype pattern is basically just a fancy
name for Object cloning.

```cs
var car1 = new Car();
car1.make = "fiesta";
car1.colour = "black";

var car2 = car1;   // !!!

// This line, of course, points
// the `car2` variable to the same
// object as `car1`.
```

Some languages, like JavaScript,
have the Prototype pattern built in
to every object by default.

The car class should have overload
the constructor with a parameter of
it's own type.

```cs
class Car
{
    string make;
    string colour;

    public Car() {}

    public Car(Car toClone)
    {
        this.make = toClone.make;
        this.colour = toClone.colour;
    }
}
```

A `Prototype` interface should be used
for all classes that should be able to
be cloned.  
This interface usually defines a method
called `clone()`.

---

Note that if a class has a reference field,
this should be accounted for.  
Should the cloned object take a reference
copy of this field, or should it have its
own.  
If it should have its own, does it need
to be a clone or can it just be default.
