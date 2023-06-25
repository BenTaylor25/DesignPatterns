# Template Method

When you have an algorithm
that varies slightly with
different data / context,
you can use the Template
Method Design Pattern to
define the skeleton of the
algorithm in a base class,
and override the methods
that need to be suited to
the data /context.

```cs
abstract class BaseGameLoader
{
    public void Load()
    {
        var data = LoadLocalData();
        CreateObjects(data);
        DownloadAdditionalFiles();
        CleanupTempFiles();
        InititaliseProfile();
    }

    abstract string LoadLocalData();
    abstract void CreateObjects(string data);
    abstract void DownloadAdditionalFiles();
    void CleanupTempFiles()
    {
        // Methods can have default implementations
    }
    abstract void InitialiseProfile();
}
```

```cs
BaseGameLoader game1 = new GameOneLoader();

game1.Load();
```
