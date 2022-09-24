using System;

namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of the matrix:");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int sum1 = 0;
            int sum2 = 0;
            int result = 0;

            Console.WriteLine("Values: ");

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] temp = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = temp[j];
                }       
            }
           

            for (int i = 0; i < matrix.GetLength(0); i++)
            {               
                sum1= sum1 + matrix[i, i];
            }

            int temp2 = 0;

            for (int i = matrix.GetLength(0)-1; i >=0; i--)
            {                
                sum2=sum2 + matrix[i, temp2];
                temp2++;
            }

            if(sum1 > sum2)
            {
                result = sum1 - sum2;
                Console.WriteLine("Result: {0}",result);
            }
            else
            {
                result = sum2 - sum1;
                Console.WriteLine("Result: {0}", result);
            }

        }
    }
}