using System;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = input.Select(int.Parse).ToArray();
        int temp = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j + 1];
                    numbers[j + 1] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        foreach (var numb in numbers)
        {
            Console.Write(numb);
            Console.Write(" ");
        }
            Console.WriteLine();

    }
}

