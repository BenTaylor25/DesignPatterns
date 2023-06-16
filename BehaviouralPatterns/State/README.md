# State

The State Pattern is closely related
to Finite State Machines; the behaviour
of a particular interaction is
dependent on the current state.

There is a `Context` class (the thing
that has a particular state) which
stores a `ConcreteState` object using
the `IState` interface.

The Client can interact with the
`Context` and the `ConcreteState`.

---

The **State** and **Strategy** Patterns
are quite similar; both are based on
composition, and change the behaviour
of the context using helper object.  
Strategies are independent and unaware
of each other.  
States can be dependent as you can
jump between states.

The Strategy Pattern is used for different
implementation of the same idea.  
e.g. Sorting.

The State Pattern is used for doing
different things.
