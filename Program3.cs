using System;

namespace JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rows:");
            int rows = int.Parse(Console.ReadLine());

            int[][]jagged=new int[rows][];

            for(int i=0; i<rows; i++)
            {
                jagged[i]=Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for(int i=0; i<jagged.Length; i++)
            {
                if (i == jagged.Length-1)
                {
                    break;
                }
                else
                {
                    if (jagged[i].Length == jagged[i + 1].Length)
                    {
                        for(int j=0; j < jagged[i].Length; j++)
                        {
                            jagged[i][j]=jagged[i][j]*2;
                        }
                        for (int j = 0; j < jagged[i+1].Length; j++)
                        {
                            jagged[i+1][j] = jagged[i+1][j] * 2;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            jagged[i][j] = jagged[i][j] / 2;
                        }
                        for (int j = 0; j < jagged[i + 1].Length; j++)
                        {
                            jagged[i + 1][j] = jagged[i + 1][j] / 2;
                        }
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                if (command[0] == "End")
                {
                    break;
                }

                else
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if(row < 0 || col < 0 || row>=jagged.Length || col >= jagged[row].Length)
                    {
                        
                    }
                    else
                    {
                        if (command[0] == "Add")
                        {
                            jagged[row][col] += value;
                        }
                        if (command[0] == "Subtract")
                        {
                            jagged[row][col] -= value;
                        }
                    }                    
                }
            }

            for(int i = 0; i < jagged.Length; i++)
            {
                for(int j =0;j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}