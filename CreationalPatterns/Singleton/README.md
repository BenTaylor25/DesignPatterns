# Singleton

The Singleton pattern ensures that
only one instantiation of a class
can exist.

It is probably the simplest, but
one of the most common patterns.

---

When multithreading is being used,
the Singleton pattern gets a little
more complicated.

If two threads access the Singleton
at the same time, they may enter
the Object Creation if statement.
This means that the second call
will overwrite the first call.

In Java we could overcome this using
a `synchronized` block, but this
introduces a new issue. If thread
A enters the `synchronized` block,
thread B may return a half-initiallised
object before thread A is done.  
We can avoid this by declaring the
static singleton variable as `volatile`.

Declaring a variable as `volatile`
means that it cannot be cached;
any time it is accessed, it must be
retreived from memory.  
A local copy can be created in the
`getInstance()` method to improve
performance.

```java
private class Singleton {
    // volatile: could return half-initialised, so don't
    private static volatile Singleton instance;
    private String data;

    private Singleton(String data) {
        this.data = data;
    }

    public static Singleton getInstance(String data) {
        Singleton result = instance;   // cache volatile variable

        // if the object has already been initialised, skip to return
        if (result == null) {
            // can only be used by one thread at a time
            synchronized (Singleton.class) {
                result = instance;   // get most recent version of instance
                if (result == null) {
                    instance = result = new Singleton(data);
                }
            }
        }

        return result;
    }
}
```
