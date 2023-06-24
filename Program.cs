
void PrintMenu(string[] options)
{
    int i = 0;
    foreach (var option in options)
    {
        Console.WriteLine($"{i++}. {option}");
    }
}

string MenuInput(string[] options)
{
    int choice = -1;
    do
    {
        Console.Write("--> ");
        string? inp = Console.ReadLine();

        bool invalidInp = !int.TryParse(inp, out choice);
        if (invalidInp) {
            choice = -1;
        }

    } while (choice < 0 || choice >= options.Length);

    return options[choice];
}

void CreationalPatternsMenu()
{
    bool repeat = true;
    while (repeat)
    {
        var menuOptions = new string[]{
            "Back",
            "Abstract Factory",
            "Builder",
            "Factory Method",
            "Prototype",
            "Singleton"
        };

        PrintMenu(menuOptions);
        string choice = MenuInput(menuOptions);
        Console.WriteLine();

        switch (choice)
        {
            case "Back":
                repeat = false;
                break;
            case "Abstract Factory":
                AbstractFactory.AbstractFactory.Execute();
                break;
            case "Builder":
                Builder.Builder.Execute();
                break;
            case "Factory Method":
                FactoryMethod.FactoryMethod.Execute();
                break;
            case "Prototype":
                Prototype.Prototype.Execute();
                break;
            case "Singleton":
                Singleton.Singleton.Execute();
                break;
            default:
                Console.WriteLine("Error: Creational Pattern switch failed");
                break;
        }

        if (choice != "Back") {
            Console.WriteLine();
        }
    }
}

void StructuralPatternsMenu()
{
    bool repeat = true;
    while (repeat)
    {
        var menuOptions = new string[]{
            "Back",
            "Adapter",
            "Bridge",
            "Composite",
            "Decorator",
            "Facade",
            "Flyweight",
            "Proxy"
        };

        PrintMenu(menuOptions);
        string choice = MenuInput(menuOptions);
        Console.WriteLine();

        switch (choice)
        {
            case "Back":
                repeat = false;
                break;
            case "Adapter":
                Adapter.Adapter.Execute();
                break;
            case "Bridge":
                Bridge.Bridge.Execute();
                break;
            case "Composite":
                Composite.Composite.Execute();
                break;
            case "Decorator":
                Decorator.Decorator.Execute();
                break;
            case "Facade":
                Facade.Facade.Execute();
                break;
            case "Flyweight":
                Flyweight.Flyweight.Execute();
                break;
            case "Proxy":
                Proxy.Proxy.Execute();
                break;
            default:
                Console.WriteLine("Error: Structural Pattern switch failed");
                break;
        }

        if (choice != "Back") {
            Console.WriteLine();
        }
    }
}

void BehaviouralPatternsMenu()
{
    bool repeat = true;
    while (repeat)
    {
        var menuOptions = new string[]{
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
        };

        PrintMenu(menuOptions);
        string choice = MenuInput(menuOptions);
        Console.WriteLine();

        switch (choice)
        {
            case "Back":
                repeat = false;
                break;
            case "Chain of Responsibility":
                ChainOfResponsibility.ChainOfResponsibility.Execute();
                break;
            case "Command":
                Command.Command.Execute();
                break;
            case "Interpretor":
                Console.WriteLine("not implemented yet");
                break;
            case "Iterator":
                Iterator.Iterator.Execute();
                break;
            case "Mediator":
                Mediator.Mediator.Execute();
                break;
            case "Memento":
                Memento.Memento.Execute();
                break;
            case "Observer":
                Observer.Observer.Execute();
                break;
            case "State":
                State.State.Execute();
                break;
            case "Strategy":
                Strategy.Strategy.Execute();
                break;
            case "Template Method":
                Console.WriteLine("not implemented yet");
                break;
            case "Visitor":
                Visitor.Visitor.Execute();
                break;
            default:
                Console.WriteLine("Error: Behavioural Pattern switch failed");
                break;
        }

        if (choice != "Back") {
            Console.WriteLine();
        }
    }
}

void MainMenu()
{
    bool repeat = true;
    while (repeat)
    {
        var menuOptions = new string[]{
            "Quit",
            "Creational Patterns",
            "Structural Patterns",
            "Behavioural Patterns"
        };

        PrintMenu(menuOptions);
        string choice = MenuInput(menuOptions);

        if (choice != "Quit") {
            Console.WriteLine();
        }

        switch (choice)
        {
            case "Quit":
                repeat = false;
                break;
            case "Creational Patterns":
                CreationalPatternsMenu();
                break;
            case "Structural Patterns":
                StructuralPatternsMenu();
                break;
            case "Behavioural Patterns":
                BehaviouralPatternsMenu();
                break;
            default:
                Console.WriteLine("Error: Main Menu switch failed");
                break;
        }
    }
}

MainMenu();
