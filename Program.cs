
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
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

        var textInput = "";

        do
        {
            textInput += Console.ReadLine();

            if (string.IsNullOrEmpty(textInput))
            {

                Console.WriteLine("Inavelid input!!");
                return;
            }

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine(textInput);
    }
}