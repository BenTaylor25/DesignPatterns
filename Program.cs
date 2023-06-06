
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

}

void BehaviouralPatternsMenu()
{

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
