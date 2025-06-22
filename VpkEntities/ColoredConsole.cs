using System;
using System.Threading;

namespace VpkEntities;

public static class ColoredConsole
{
    private static readonly Lock Lock = new ();

    public static void Print(ConsoleColor color, string buffer, params object[] args)
    {
        lock (Lock)
        {
            var c = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(buffer, args);
            Console.ForegroundColor = c;
        }
    }
}
