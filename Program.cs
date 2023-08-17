﻿
internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch(ReturningMenuText());

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

        var text = "";

        do
        {
            var textInput = Console.ReadLine();
            text += textInput;
            text += Environment.NewLine;
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine(" ");
        
        Console.WriteLine("Your new text file:");
        Console.WriteLine(text);
        
        Console.WriteLine(" ");

        Salve(text);

    }

    static void Saved(string text) 
    {
        Console.WriteLine("do you Which way salve?");
        var path = Console.ReadLine();
        try
        {
            using (var file = new StreamWriter(path))
            {
                file.WriteLine(text);
                Console.WriteLine(" ");
                Console.WriteLine("Successfully saved file...");
            }

            Stopwatch(ReturningMenuText());
        }
        catch
        {
            Console.WriteLine("Invalid input.");
            Stopwatch(ReturningMenuText());
            Menu();
        }
    }

    static void Stopwatch(string text)
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