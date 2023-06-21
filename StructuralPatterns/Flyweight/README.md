# Flyweight

The Flyweight Pattern is used
to decrease memory usage when
a large amount of objects are
being created and used.

This is achieved by sharing
common parts of state between
multiple objects.

Consider the class:

```cs
class Book
{
    string name;
    double price;
    string genre;
    string publisher;
}
```

The `name` and `price` attributes
are likely to vary between most pairs
of `Book`s, but the `genre` and
`publisher` may be shared by many.

In this case, we can separate the
shared attributes into a flyweight
class, and join it back to `Book`
via composition.

```cs
class Book
{
    string name;
    double price;
    BookInfo bookInfo;
}

class BookInfo
{
    string subgenre
    string genre;
}
```

Important note:
not only are the flyweight
attributes shared by many
`Book` objects, they are also
unlikely to change.  
A `Book` doesn't change `genre`
once it has been released.  
This is important because changing
a flyweight value for one object
would cause changes for other
objects that share it.  
Reallocating flyweight objects
instead of changing values would
be complex and slow.

Extrinsic State; (`name` and `price`),
attributes in the base class. They vary
between objects, and may be changed at
runtime.

Intrinsic State; (`subgenre` and `genre`),
attributes in the flyweight class. They
are shared between objects, and must not
be modified once created.

Flyweight classes are managed using
Flyweight Factories.

```cs
class BookFactory
{
    static Dictionary<string, BookType> bookTypes = new();

    public static BookType GetBookType(string subgenre, string genre)
    {
        if (!bookTypes.ContainsKey(subgenre))
        {
            bookTypes.Add(subgenre, new BookType(subgenre, genre));
        }
        return bookTypes[subgenre];
    }
}

class Book
{
    string name;
    double price;
    BookType bookType;

    public Book(string name, double price, string subgenre, string genre)
    {
        this.name = name;
        this.price = price;
        this.bookType = BookFactory.GetBookType(subgenre, genre);
    }
}
```
