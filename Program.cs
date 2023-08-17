
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
            return;
        }

        var option = int.Parse(input);

        switch (option)
        {
            case 0:
                Console.WriteLine("Exit...");
                break;
            case 1:
                Console.WriteLine("Open file..");
                OpenFile();
                break;
            case 2:
                Console.WriteLine("Create new file..");
                NewFile();
                break;
            default:
                Menu();
                break;
        }

    }

    static void OpenFile()
    {
    }

    static void NewFile()
    {
        Console.Clear();

        Console.WriteLine("     Enter your text below");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(" ");

        var newString = "";

        do
        {
            var textInput = Console.ReadLine();
            newString += textInput;
            newString += Environment.NewLine;
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine(" ");
        
        Console.WriteLine("Your new text file:");
        Console.WriteLine(newString);
        
        Console.WriteLine(" ");

        Console.WriteLine("Returning to the Menu...");
        Thread.Sleep(3000);

        Menu();
    }
}