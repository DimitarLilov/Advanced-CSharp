using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(input);
        Console.WriteLine(reversed);
    }
    static double GetReversedNumber(double num)
    {
        bool isNegative = num < 0;
        string inputStr = string.Join("", num.ToString().TrimStart('-').Reverse());
        double number = double.Parse(inputStr);
        return isNegative ? -number : number;
    }
}

