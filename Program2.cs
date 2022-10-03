using System;

namespace MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rows and cols: ");
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] array = new int[rows, cols];

            Console.WriteLine("Elements:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] temp = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = temp[j];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                if (command[0] == "swap")
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    if(row1 <0 || row2 <0 || col1 <0 || col2 <0 || row1>=array.GetLength(0) || row2>=array.GetLength(0) || col1 >= array.GetLength(1) || col2 >= array.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    else
                    {
                        int temp = array[row2, col2];

                        array[row2, col2] = array[row1, col1];
                        array[row1, col1] = temp;

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write(array[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }

        }
    }
}