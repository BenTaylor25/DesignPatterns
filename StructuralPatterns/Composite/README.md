# Composite

Consider a box that contains the following:
```
- Box
    - Box
        - Box
            - Product (£8)
        - Product (£7)
    - Product (£5)
    - Product (£2)
```

How can we calculate the total price of the outer Box?

One option would be to use a method `boxSum()` to
iterate through all `Product`s directly in the `Box`,
calculating their sum price.  
Then iterate through all of the `Box`es,
adding the result of `child.boxSum()` to the outer sum.

(This seems a perfectly reasonable solution to me...)

The Composite pattern suggests the addition of a
common interface (e.g. `summable` in this case),
which allows the `Box` class to iterate through only one collection,
calling the same method for `Box`es and `Product`s.

More broadly, the Composite pattern applies to data
in a Tree structure with **Composite children**
(children that can contain more children),
and **Leaf children**
(children that cannot contain more children).
