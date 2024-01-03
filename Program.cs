while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Press A to Start\nPress Q to Exit");
    var keyPressed = Console.ReadKey(true);
    switch (keyPressed.Key)
    {
        case ConsoleKey.A:
            DeleteFiles();
            break;
        case ConsoleKey.Q:
            Console.WriteLine("Exiting the application \n");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid key pressed \n");
            continue;
    }
}

static void DeleteFiles()
{
    Console.WriteLine("Please enter the file path");
    string? path = Console.ReadLine();
    if (!string.IsNullOrEmpty(path))
    {
        if (Directory.Exists(path))
        {
            FileDeletor.FileDeletor.DeleteFilesFromPath(path);
        }
        else
        {
            Console.WriteLine("\nThe given directory does not exist");
        }
    }
    else
    {
        Console.WriteLine("Invalid path given please try again.");
    }
}

