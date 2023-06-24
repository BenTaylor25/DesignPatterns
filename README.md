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


## Prototype


## Singleton
