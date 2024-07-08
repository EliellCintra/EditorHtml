using System;
using System.Text;
using System.Text.RegularExpressions;

namespace EditorHtml;

public class Viewer
{
    public static void Start(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("\n\t\tVISUALISATION\n");
        Console.WriteLine("_________________________________________\n");
        Replace(text);
        Console.WriteLine("_________________________________________\n");
    }

    static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = text.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            if (strong.IsMatch(words[i]))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(
                    words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        (
                            words[i].LastIndexOf('<') - 1 -
                            words[i].IndexOf('>')
                        )
                    )
                );
                Console.Write(" ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(words[i]);
                Console.Write(" ");
            }
        }
        Console.WriteLine("\n");
    }
}