# SOLID Principles

SOLID is an acronym of 5 Object-Oriented
design principles aimed at making more
understandable, flexible, and maintainable
code.

The big 23 Design Patterns follow the
SOLID principles. Utilising Design
Patterns properly makes it easier
for the developer to write SOLID
code.

- Single Responsibility Principle
- Open-closed Principle
- Liskov Substitution Principle
- Interface Segregation Principle
- Dependency Inversion Principle


## Single Responsibility Principle

Every class must only have one purpose;
one reason to be changed.  

```cs
class FileIOManager
{
    public string ReadFile(string filename)
    {
        ...
    }

    public void WriteFile(string filename, string text)
    {
        ...
    }

    public string EncryptFile(string plaintext)
    {
        ...
    }

    public string DecryptFile(string ciphertext)
    {
        ...
    }
}
```

This class violates the Single Responsibility
Pattern as it handles file read/write, and
encryption/decryption.  
(file read and file write can reasonably be
considered a single responsibility, likewise
with encryption/decryption).

```cs
class FileIOManager
{
    public string ReadFile(string filename)
    {
        ...
    }

    public void WriteFile(string filename, string text)
    {
        ...
    }
}

class FileEncryption {
    public string EncryptFile(string plaintext, string filename)
    {
        ...
    }

    public string DecryptFile(string ciphertext, string filename)
    {
        ...
    }
}
```

Encryption should be handled by a different class.


## Open-Closed Principle

The Open-Closed Principle states that objects should
be open for extension, but closed for modification.

During development, things change all of the time,
but once a build reaches deployment, you need to
be careful.

Consider the following list of Employees:

```cs
List<Employee> employees = new List<Employee>
{
    new Employee { FirstName = "Ben", LastName = "Taylor" },
    new Employee { FirstName = "Bob", LastName = "Smith" }
};
```

It would be difficult to add a `Manager`, `Executive`,
or other distinct member of staff to this collection.  
Developers may feel inclined to add a property to
the Employee class to indicate the type, but this
violates OCP.

If, instead, we use an interface for the collection
type, we can instead use a new class to add the
new functionality. Open for extension, Closed for
modification.

```cs
List<IEmployee> employees = new List<IEmployees>
{
    new Employee { FirstName = "Ben", LastName = "Taylor" },
    new Manager { FirstName = "Bob", LastName = "Smith" }
};
```


# Liskov Substitution Principle

The Liskov Substitution Principle states that
class instantiation should always be able to
be replaced with subclass instantiation.

```cs
Employee emp = new Employee();

Console.WriteLine(emp.GetManager());
```

If `Manager` inherits from `Employee`,
the first line should be replaceable with

```cs
Employee emp = new Manager();
```

and the program should not break.

Child classes can change the behaviour of
the parent, but they should not be able
to remove behaviour.

The Liskov principle also states that you
cannot strengthen preconditions or weaken
postconditions of inherited methods.

```cs
class Employee
{
    public void Foo(int x) {}
}

class Manager : Employee
{
    public void Foo(int x)
    {
        if (x < 0)
        {
            throw new Exception();
        }
    }
}
```

This violates LSP because `Manager.Foo()`
may throw an error where `Employee.Foo()`
doesn't.
