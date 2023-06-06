
// FactoryMethod.FactoryMethod.Execute();
// Builder.Builder.Execute();

Composite.Composite.Execute();

void MainMenu()
{
    bool repeat = true;
    while (repeat)
    {
        Console.WriteLine("0. Quit");
        Console.WriteLine("1. Creational Patterns");
        Console.WriteLine("2. Structural Patterns");
        Console.WriteLine("3. Behavioural Patterns");

        int choice = -1;
        do
        {
            Console.Write("-->");
            string? inp = Console.ReadLine();

            bool invalidInp = !int.TryParse(inp, out choice);
            if (invalidInp) {
                choice = -1;
            }

        } while (choice < 0 || choice > 3);

        if (choice == 0) {
            repeat = false;
        }
    }
}

// MainMenu();
