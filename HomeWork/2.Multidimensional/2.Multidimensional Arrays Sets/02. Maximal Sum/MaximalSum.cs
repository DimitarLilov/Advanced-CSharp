using System;

class MaximalSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int[,] matrix = new int[n, m];
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        MakeMatrix(n, m, matrix);
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]+
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }
        Console.WriteLine("Sum = {0}", maxSum);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
        


    }

    static void MakeMatrix(int n, int m, int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] number = Console.ReadLine().Split();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(number[col]);
            }
        }
    }
}

