using System;
class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        //Pattern A
        int i = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[row, col] = i++;
            }
        }

        PrinMatrix(matrix); // Print Matrix A
        Console.WriteLine();
        //Pattern B
        i = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {

            if (col % 2 == 0 && col >= 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                     matrix[row, col] = i++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = i++;
                }
            }
        }
        PrinMatrix(matrix);// Print Matrix B
    }
    static void PrinMatrix(int[,] matrix)
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

