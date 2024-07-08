using System;
using System.Runtime.CompilerServices;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Start()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            DrawScreen();
            WriteOption();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            HorizontalLines(40);
            VerticalLines(10, 40);
            HorizontalLines(40);


            static void HorizontalLines(int numberOfColumns)
            {
                Console.Write("+");
                for (int i = 0; i <= numberOfColumns; i++)
                    Console.Write("-");
                Console.Write("+");
                Console.Write("\n");
            }

            static void VerticalLines(int numberOfLines, int numberOfColumns)
            {
                for (int lines = 0; lines <= numberOfLines; lines++)
                {
                    Console.Write("|");
                    for (int y = 0; y <= numberOfColumns; y++)
                        Console.Write(" ");
                    Console.Write("|");
                    Console.Write("\n");
                }
            }

        }

        public static void WriteOption()
        {
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("\t\tEDITOR HTML");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("1 - New file");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("2 - Open file");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Select an option: ");
            Console.SetCursorPosition(20, 7);

        }

        public static void HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1: Editor.Start(); break;
                case 2: OpenFile.Start(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Start(); break;
            }
        }

    }
}
