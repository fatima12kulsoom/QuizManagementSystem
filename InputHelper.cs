#nullable disable
using System;

class InputHelper
{
    // Read Integer
    public static int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Read String
    public static string ReadString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    // Read Character
    public static char ReadChar(string message)
    {
        Console.Write(message);
        return Convert.ToChar(Console.ReadLine().ToUpper());
    }
}