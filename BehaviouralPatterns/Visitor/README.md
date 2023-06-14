# Visitor

The Visitor pattern separates the
algorithms or behaviours from the
Objects on which they operate.

The Visitor pattern can introduce
a lot of complexity, so it is
important not to use it for
classes that are likely to be
refactored or drastically changed.  
It is best suited for stable
classes that frequently need
new operations without modifying
the original class.

Consider the following classes:
```
- Shape
    - getArea()

- Circle : Shape
    - override getArea()

- Rectangle : Shape
    - override getArea()
```

The area-calculation logic in the
classes above are all seperated
into the respective classes.  
The visitor pattern suggests
placing all area-calculation logic
in the same class, and having each
Shape invoke the relevant calculation.

In order to achieve this, we introduce
a class `AreaCalculator` which implements
an interface `IShapeVisitor`.  
`IShapeVisitor` should declare the
`visit()` method overloaded with each of
the concrete `Shape` classes.  
`AreaCalculator` then defines each method
overload with the area-calculation logic.

Each concrete `Shape` should define an
`accept()` method that takes an
`IShapeVisitor` as a parameter, and calls
it's visit method with `this` (which will
select the respective concrete implementation).
