
internal class Program
{

    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("What do you want to do?");
        Console.WriteLine("0- Exit");
        Console.WriteLine("1- Open file");
        Console.WriteLine("2- Create new file");

        var input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input invalid");
            Thread.Sleep(1500);
            Menu();
            return;
        }

        var option = int.Parse(input);

        switch (option)
        {
            case 0:
                Console.WriteLine("\nExit...");
                break;
            case 1:
                Console.WriteLine("\nOpen file..");
                OpenFile();
                break;
            case 2:
                Console.WriteLine("\nCreate new file..");
                NewFile();
                break;
            default:
                Menu();
                break;
        }

    }

    static void OpenFile()
    {
        Console.WriteLine("\nEnter the path to the file you want to access:");
        var path = Console.ReadLine();


        if (string.IsNullOrEmpty(path))
        {
            Console.WriteLine("\nInvalid input");
            ReturningMenu(ReturningMenuText());
            Menu();
            return;
        }

        using (var file = new StreamReader(path))
        {
            Console.WriteLine(file.ReadToEnd());
        }

        Console.WriteLine("\n'ENTER' press to continue in the menu or 1 to delete file");

        var resposta = Console.ReadKey().Key;

        if (resposta == ConsoleKey.D1)
        {
            DeleteFile(path);
        }
        
        if (resposta == ConsoleKey.Enter || resposta == ConsoleKey.D1)
        {
            ReturningMenu(ReturningMenuText());
        }
    }

    static void NewFile()
    {
        Console.Clear();

        Console.WriteLine("     Enter your text below");
        Console.WriteLine("----------------------------------\n");

        var text = "";

        do
        {
            var textInput = Console.ReadLine();
            text += textInput;
            text += Environment.NewLine;
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        Console.WriteLine("-------------------------------------------\n");

        Console.WriteLine("Your new text file:\n");
        Console.WriteLine(text);

        Saved(text);

    }

    static void DeleteFile(string file)
    {
        if (File.Exists(file))
        {
            File.Delete(file);
            Console.WriteLine("\nSuccessfully deleted file\n");
            Thread.Sleep(2000);
        }

        else Console.WriteLine("Null");
    }

    static void Saved(string text)
    {
        Console.WriteLine("do you Which way salve?");
        var path = Console.ReadLine();

        if (string.IsNullOrEmpty(path))
        {
            Console.WriteLine("Invalid input");
            ReturningMenu(ReturningMenuText());
            return;
        }
        using (var file = new StreamWriter(path))
        {
            file.WriteLine(text);
            Console.WriteLine("\nSuccessfully saved file...");
            Thread.Sleep(1500);
        }

        ReturningMenu(ReturningMenuText());


    }

    static void ReturningMenu(string text)
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Clear();

            Console.WriteLine($"{text}{i}");
            Thread.Sleep(1000);
        }
        Menu();
    }

    static string ReturningMenuText()
    {
        return "Retorning to the menu in...";
    }


}
