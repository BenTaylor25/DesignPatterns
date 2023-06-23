# Iterator

Consider a tour guide that
is familiar with several
landmarks.
Different tourists may be
interested in different
landmarks, so the tour
guide may have different
routes of different
combinations of landmarks.

The Iterator Design Pattern
is used to abstract out the
traversal of a collection.

This would, for example,
allow the tour guide to show
landmarks in alphabetical order,
reverse-alphabetical order,
using the nearest-neighbour
algorithm, or other.

A typical iterator looks
something like this:
```cs
public interface Iterator<T>
{
    bool HasNext();
    T GetNext();
    void Reset();
}
```

This Pattern is built in to
many programming languages,
mainly for use in loops.

```py
tup = ("apples", "bananas", "cherries")
it = iter(tup)

print(next(it))   # apples
print(next(it))   # bananas
print(next(it))   # cherries
```

```py
for x in tup:
    print(x)

# is syntactic sugar for

it = iter(tup)
while it:
    print(next(it))
```

This general iterator is
typically an in-order
traversal of the collection.
