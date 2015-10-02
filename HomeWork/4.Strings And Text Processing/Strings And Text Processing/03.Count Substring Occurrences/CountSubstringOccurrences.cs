using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string substring = Console.ReadLine().ToLower();
        int counter = 0;
        int poss = input.IndexOf(substring);
        while (poss >= 0 && poss <= input.Length)
        {
            counter++;
            poss = input.IndexOf(substring, poss + 1);

        }
        Console.WriteLine(counter);
    }
}