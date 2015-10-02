using System;
using System.Linq;

class SortArray
{
    static void Main()
    {
        string inputstring = Console.ReadLine();
        int[] numbers = inputstring.Split().Select(int.Parse).ToArray();
        Array.Sort(numbers);
        foreach (var numb in numbers)
        {
            Console.Write("{0} ", numb);
        }
        Console.WriteLine();

    }
}

