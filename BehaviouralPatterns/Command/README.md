# Command

Consider the following class

```cs
class Calculator
{
    public double value = 0;

    public void add(double value)
    {
        this.value += value;
    }

    public void sub(double value)
    {
        this.value -= value;
    }

    public void mul(double value)
    {
        this.value *= value;
    }

    public void div(double value)
    {
        this.value /= value;
    }
}
```

This class has 4 methods that modify
the state.  
These 4 methods can be abstracted out
of the class into a Command object.  
This could allow more dynamic
functionality, and could allow us
to undo commands more easily.

The Command Pattern also allows a
specific functionality to be applied
to different classes.

Typically you will want classes to store
an array of commands that they've executed
to make the undo functionality easier.

---

The Command Pattern is especially useful
for building a text editor.
