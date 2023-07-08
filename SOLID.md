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
