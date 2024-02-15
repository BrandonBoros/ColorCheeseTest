using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheeser
{
    public class Text
    {
        public static void WriteLine(int color, string text)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void Write(int color, string text)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static string ReadLine(int color)
        {
            string input;

            Console.ForegroundColor = (ConsoleColor)color;
            input = Console.ReadLine();

            return input;
        }
    }
}
