using System;

class EqualStrings
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                Console.Write("{0} ", input[i]);
                
            }
            else if (input[i] != input[i + 1])
            {
                Console.WriteLine(input[i]);
                
            }
            if (i == input.Length - 2)
            {
                Console.WriteLine(input[i + 1]);
                
            }
        }
        if (input.Length == 1)
        {
            Console.WriteLine(input[0]);
        }
    }
}

