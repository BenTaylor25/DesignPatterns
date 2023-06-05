# Builder

When you have a class with many fields,
the constructor can become very large to call.  
e.g.
```cs
class Person
{
    string name;
    int age;
    string occupation;
    string birthday;
    string favColour;
    // ...
}

// This line is very long
Person me = new("Ben", 19, "Software Engineer", "25th July", "Blue");
```

This is especially undesirable when some fields are optional.  
If `age`, `occupation`, and `birthday` were optional,
and you wanted to specify `name` and `favColour`,
you would have to do something like:

```cs
Person me = new("Ben", 0, null, null, "Blue");
```

(Or overload the constructor for every combination of fields).

Not only is this line long,
but now we have a `0` and 2 `null`s whose purpose is unclear.

---

The Builder pattern splits the constructor into
seperate, chainable steps.

```cs
Person person = new("Ben")   // required parameters
    .SetFavColour("Blue")   // optional parameters
    .SetAge(19)   // in any order
    .Build();
```

Required parameters should be passed into the Builder constructor.  
Optional parameters can be set with chained methods in any order.  
A `Build()` method is called at the end to return the object.
