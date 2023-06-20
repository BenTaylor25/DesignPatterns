# Decorator

The Decorator Design Pattern
allows you to attach new
behaviours to existing objects
using a wrapper.

When you make a cup of Tea,
some people will want sugar,
but some people will want milk.
Some people will want both, and
others will want neither.  
In this case, we can create a
`Tea` class, and Decorators for
`Milk` and `Sugar`.

This will allow you to create
```cs
var blackTea = new Tea();

var teaWithMilk = new Milk(new Tea());

var teaWithSugar = new Sugar(new Tea());

var teaWithMilkAndSugar = new Milk(
    new Sugar(new Tea())
);

/* or
var teaWithMilkAndSugar = new Sugar(
    new Milk(new Tea())
);
*/
```
