using System;
using System.Linq;

class FirstLargerThanNeighbours
{

    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };
        Console.WriteLine(GetIndexFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexFirstElementLargerThanNeighbours(sequenceThree));

        string input = Console.ReadLine();
        int[] numbers = input.Split().Select(int.Parse).ToArray();
        Console.WriteLine(GetIndexFirstElementLargerThanNeighbours(numbers));

    }
    private static int GetIndexFirstElementLargerThanNeighbours(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            if (IsLargerThanNeighbours(num, i))
            {
                return i;
            }
        }
        return -1;
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

