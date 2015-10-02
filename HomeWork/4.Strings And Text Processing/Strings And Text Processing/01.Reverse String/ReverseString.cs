using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        string outputString = string.Empty;
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            outputString += inputString[i];
        }
        Console.WriteLine(outputString);

        //char[] inputarray = inputString.ToCharArray();
        //Array.Reverse(inputarray);
        //string output = new string(inputarray);
        //Console.WriteLine(output);
    }
}

