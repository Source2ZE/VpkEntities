using System;
using System.IO;

namespace VpkEntities;

public static class ConsoleAction
{
    private static TextWriter DefaultWriter = TextWriter.Null;

    public static void StartContext()
    {
        DefaultWriter = Console.Out;
    }

    public static void EndContext()
    {
        ColoredConsole.Print(ConsoleColor.Blue, "\n\nPress any key to continue...");
        Console.ReadKey(true);
    }

    public static void DisableOutput()
    {
        DefaultWriter = Console.Out;
        Console.SetOut(TextWriter.Null);
    }

    public static void EnableOutput()
    {
        Console.SetOut(DefaultWriter);
    }
}
