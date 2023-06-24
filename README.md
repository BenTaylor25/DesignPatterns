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

The big 23 Design Patterns are
split into 3 categories:
- Creational
- Structural
- Behavioural


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

## Prototype


## Singleton
