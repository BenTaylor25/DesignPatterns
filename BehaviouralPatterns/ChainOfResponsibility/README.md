# Chain of Responsibility

The Chain of Responsibility pattern
is where multiple Handlers are used
to validate a request.  
Each Handler can handle the request
(or reject it), or pass it to the
next Handler in the chain.

If we have an online shop, there are
several steps that need to be made.  
e.g.
- Check if the item is in stock.
- Check the customer's balance.
- Handle shipping.
- Deliver a notification.

We can define these Handlers seperately
and link them together.

e.g.
```cs
if (Inventory.IsAvailable(product))
{
    if (next != null)
    {
        next.process(product);
    }
    else
    {
        Console.WriteLine("finished");
    }
}
else
{
    Console.WriteLine("Inventory check failed");
}
```
