using System;

namespace EditorHtml;

public class OpenFile
{
    public static void Start()
    {
        Header();
        var text = ReadFile();
        Viewer.Start(text);
    }
    static string ReadFile()
    {
        Console.WriteLine("Enter the file path:");
        string path = Console.ReadLine();

        using var file = new StreamReader(path);
        return file.ReadToEnd();
    }

    static void Header()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("\n\t\tOPEN FILE\n");

    }
}