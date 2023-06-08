# Observer

Notifies multiple subscriber objects
about events on the emitting object.

Consider the scenario where a
`Customer` goes to a `Shop`,
but the `Shop` does not have the
product they want.  
The `Customer` could return to
the `Shop` at regular intervals
to check again, or the `Shop`
could alert all `Customer`s when
a product is back in stock.  
The former is inconvenient for
the single `Customer`, and the
latter is annoying for the many
`Customer`s that aren't interested
in that particular product.

The Observer pattern allows
interested `Customer`s to
subscribe to particular
notifications.  
The `Shop` will send out a
notification that a product
is back in stock, but only
the subscriber `Customer`s
will receive it.
