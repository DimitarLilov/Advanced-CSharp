using System;
using System.Collections.Generic;
using System.Linq;
class CategorizeNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        decimal[] numbers = input.Split().Select(decimal.Parse).ToArray();
        List<decimal> roundNum = new List<decimal>();
        List<decimal> zeroFractNum = new List<decimal>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 == 0)
            {
                zeroFractNum.Add(numbers[i]);
            }
            else
            {
                roundNum.Add(numbers[i]);
            }
        }
        Console.Write("[{0}] -> ",string.Join(", ", roundNum));
        Console.Write("min: {0}, ", roundNum.Min());
        Console.Write("max: {0}, ", roundNum.Max());
        Console.Write("sum: {0}, ", roundNum.Sum());
        Console.WriteLine("avg: {0:f2}", roundNum.Average());

        Console.Write("[{0}] -> ", string.Join(", ", zeroFractNum));
        Console.Write("min: {0}, ", zeroFractNum.Min());
        Console.Write("max: {0}, ", zeroFractNum.Max());
        Console.Write("sum: {0:##}, ", zeroFractNum.Sum());
        Console.WriteLine("avg: {0:f2}", zeroFractNum.Average());
        
        

    }
}

