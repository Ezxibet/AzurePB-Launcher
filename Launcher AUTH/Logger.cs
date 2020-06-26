using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher_AUTH
{
    public static class Logger
    {
        private static void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
        public static void Error(string text)
        {
            Write(text, ConsoleColor.Red);
        }
        public static void Warning(string text)
        {
            Write(text, ConsoleColor.Green);
        }
        public static void Info(string text)
        {
            Write(text, ConsoleColor.Cyan);
        }
        public static void CheckDirectory()
        {
            if (!Directory.Exists("logs/side"))
             Directory.CreateDirectory("logs/side");
        }
    }
}
