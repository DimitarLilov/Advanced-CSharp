using System;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        foreach (char ch in input)
        {
            Console.Write(@"\u{0}", ((int)ch).ToString("x4"));
            Console.WriteLine();
        }
    }
}
