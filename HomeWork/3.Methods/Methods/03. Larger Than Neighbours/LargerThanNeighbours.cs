using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split().Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }
    static bool IsLargerThanNeighbours(int[] num, int i)
    {

        bool result;
        if (i == 0)
        {
            result = num[i] > num[i + 1];
        }
        else if (i == num.Length - 1)
        {
            result = num[i] > num[i - 1];
        }
        else
        {
            result = num[i] > num[i - 1] && num[i] > num[i + 1];
        }
        return result;

    }
}
