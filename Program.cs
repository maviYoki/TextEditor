
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

        Console.WriteLine(input);



    }
}