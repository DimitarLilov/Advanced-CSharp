using System;

class MatrixShuffling
{
    private static object input;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        string[] comand = Console.ReadLine().Split();
        while (comand[0] != "END")
        {

            if (comand[0] == "swap" && comand.Length == 5)
            {
                int row = int.Parse(comand[1]);
                int col = int.Parse(comand[2]);
                int row1 = int.Parse(comand[3]);
                int col1 = int.Parse(comand[4]);
                if (row > n || col > m || row1 > n || col > m )
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine("(after swapping {0} and {1}):", matrix[row, col], matrix[row1, col1]);
                    string temp = matrix[row, col];
                    matrix[row, col] = matrix[row1, col1];
                    matrix[row1, col1] = temp;
                    PrinMatrix(matrix);
                }
            }
           

            comand = Console.ReadLine().Split();
        }


    }
    static void PrinMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }

    }
}

