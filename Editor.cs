using System;
using System.Text;

namespace EditorHtml;

public static class Editor
{
    public static void Start()
    {
        Header();
        StringBuilder text = InputText();

        Console.Clear();
        Viewer.Start(text.ToString());

        short option = ShowOptions();

        switch (option)
        {
            case 1: Save(text); break;
            case 0: Menu.Start(); break;
            default: ShowOptions(); break;
        }
    }

    static void Header()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("\n\t\tEDITOR\n");
        Console.WriteLine("Type your text and press ESC to continue.");
        Console.WriteLine("_________________________________________\n");
    }

    static StringBuilder InputText()
    {
        var text = new StringBuilder();

        do
        {
            text.Append(Console.ReadLine());
            text.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        return text;
    }

    static short ShowOptions()
    {
        Console.WriteLine("Do you want to save this file?\n(1 - yes | 0 - no):");
        return short.Parse(Console.ReadLine());
    }

    static void Save(StringBuilder text)
    {
        Console.Clear();
        Console.WriteLine("Enter the Path:");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
        Console.Clear();
        Console.WriteLine($"File {path} saved successfully!");
        Thread.Sleep(2500);
        Menu.Start();
    }

}