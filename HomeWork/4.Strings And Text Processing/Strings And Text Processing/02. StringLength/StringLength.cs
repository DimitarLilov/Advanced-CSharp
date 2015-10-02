using System;

class StringLength
{
    static void Main()
    {
        int lengthOutputString = 20;
        string input = Console.ReadLine();
        if (input.Length < lengthOutputString)
        {

            Console.WriteLine(input + new string('*', lengthOutputString - input.Length));
        }
        else
        {
            for (int i = 0; i < lengthOutputString; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}

