using System;

namespace SquaresinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rows and cols:");
            int[]input=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[,] matrix = new string[input[0], input[1]];

            int count = 0;

            Console.WriteLine("Matrix: ");    
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                String[] letters = Console.ReadLine().Split(" ").ToArray();

                for(int j=0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = letters[j];
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(j < matrix.GetLength(1) - 1 && i < matrix.GetLength(0) - 1)
                    {
                        if(matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i+1,j] && matrix[i + 1, j] == matrix[i + 1, j + 1])
                        {
                            count++;
                        }
                    }
                }
            }


            Console.WriteLine($"Result: {count}");
        }
    }
}
