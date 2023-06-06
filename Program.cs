
// FactoryMethod.FactoryMethod.Execute();
// Builder.Builder.Execute();

// Composite.Composite.Execute();

void PrintMenu(string[] options)
{
    int i = 0;
    foreach (var option in options)
    {
        Console.WriteLine($"{i++}. {option}");
    }
}

int MenuInput(int maxValue)
{
    int choice = -1;
    do
    {
        Console.Write("-->");
        string? inp = Console.ReadLine();

        bool invalidInp = !int.TryParse(inp, out choice);
        if (invalidInp) {
            choice = -1;
        }

    } while (choice < 0 || choice > maxValue);

    return choice;
}

void CreationalPatternsMenu()
{
    bool repeat = true;
    while (repeat)
    {
        PrintMenu(new string[]{
            "Back",
            "Abstract Factory",
            "Builder",
            "Factory Method",
            "Prototype",
            "Singleton"
        });

        switch (MenuInput(5))
        {
            case 0:
                repeat = false;
                break;
            case 1:
                Console.WriteLine("not implemented yet");
                break;
            case 2:
                Builder.Builder.Execute();
                break;
            case 3:
                FactoryMethod.FactoryMethod.Execute();
                break;
            case 4:
                Console.WriteLine("not implemented yet");
                break;
            case 5:
                Console.WriteLine("not implemented yet");
                break;
        }
    }
}

void StructuralPatternsMenu()
{
    bool repeat = true;
    while (repeat)
    {
        PrintMenu(new string[]{
            "Back",
            "Adapter",
            "Bridge",
            "Composite",
            "Decorator",
            "Facade",
            "Flyweight",
            "Proxy"
        });

        switch (MenuInput(7))
        {
            case 0:
                repeat = false;
                break;
            case 1:
                Console.WriteLine("not implemented yet");
                break;
            case 2:
                Console.WriteLine("not implemented yet");
                break;
            case 3:
                Composite.Composite.Execute();
                break;
            case 4:
                Console.WriteLine("not implemented yet");
                break;
            case 5:
                Console.WriteLine("not implemented yet");
                break;
            case 6:
                Console.WriteLine("not implemented yet");
                break;
            case 7:
                Console.WriteLine("not implemented yet");
                break;
        }
    }
}

void BehaviouralPatternsMenu()
{
    bool repeat = true;
    while (repeat)
    {
        PrintMenu(new string[]{
            "Back",
            "Chain of Responsibility",
            "Command",
            "Interpreter",
            "Iterator",
            "Mediator",
            "Memento",
            "Observer",
            "State",
            "Strategy",
            "Template Method",
            "Visitor"
        });

        switch (MenuInput(11))
        {
            case 0:
                repeat = false;
                break;
            case 1:
                Console.WriteLine("not implemented yet");
                break;
            case 2:
                Console.WriteLine("not implemented yet");
                break;
            case 3:
                Console.WriteLine("not implemented yet");
                break;
            case 4:
                Console.WriteLine("not implemented yet");
                break;
            case 5:
                Console.WriteLine("not implemented yet");
                break;
            case 6:
                Console.WriteLine("not implemented yet");
                break;
            case 7:
                Console.WriteLine("not implemented yet");
                break;
            case 8:
                Console.WriteLine("not implemented yet");
                break;
            case 9:
                Console.WriteLine("not implemented yet");
                break;
            case 10:
                Console.WriteLine("not implemented yet");
                break;
            case 11:
                Console.WriteLine("not implemented yet");
                break;
        }
    }
}

void MainMenu()
{
    bool repeat = true;
    while (repeat)
    {
        PrintMenu(new string[]{
            "Quit",
            "Creational Patterns",
            "Structural Patterns",
            "Behavioural Patterns"
        });

        switch (MenuInput(3))
        {
            case 0:
                repeat = false;
                break;
            case 1:
                CreationalPatternsMenu();
                break;
            case 2:
                StructuralPatternsMenu();
                break;
            case 3:
                BehaviouralPatternsMenu();
                break;
        }
    }
}

MainMenu();
