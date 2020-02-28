namespace Bombs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Bombs
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];
            FillMatrix(rows, matrix);
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            ExplodeCells(commands, matrix);
            var aliveCells = GetAliveCells(matrix);
            Console.WriteLine($"Sum: {aliveCells.Sum()}");
            Console.WriteLine($"Cells: {String.Join(" ", aliveCells)}");
            PrintMatrix(matrix);


        }

        private static void ExplodeCells(string[] commands, int[][] matrix)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                string[] tokens = commands[i].Split(",", StringSplitOptions.RemoveEmptyEntries);
                int bombRow = int.Parse(tokens[0]);
                int bombCol = int.Parse(tokens[1]);
                int currentBombValue = matrix[bombRow][bombCol];
                if (currentBombValue > 0)
                {
                    for (int row = bombRow - 1; row <= bombRow + 1; row++)
                    {
                        for (int col = bombCol - 1; col <= bombCol + 1; col++)
                        {
                            if (matrix[row][col] > 0)
                            {
                                if (IsInside(matrix, row, col))
                                {
                                    matrix[row][col] -= currentBombValue;
                                }
                            }
                        }
                    }
                }


            }
        }
        static bool IsInside(int[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }

        static void FillMatrix(int rows, int[][] matrix)
        {
            for (int r = 0; r < rows; r++)
            {
                int[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[r] = inputData;
            }
        }
        static void PrintMatrix(int[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
        static List<int> GetAliveCells(int[][] matrix)
        {
            var lista = new List<int>();
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int col = 0; col < matrix[r].Length; col++)
                {
                    if (matrix[r][col] > 0)
                    {
                        lista.Add(matrix[r][col]);
                    }
                }
            }
            return lista;
        }
    }
}