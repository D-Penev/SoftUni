using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowSize = dimensions[0];
            if (rowSize <= 0)
            {
                return;
            }
            var matrix = new string[rowSize][];
            FillingMatrix(matrix);
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] != "swap")
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                if (tokens.Length > 5 || tokens.Length < 5)
                {
                    Console.WriteLine("Invalid input");
                }
                if (!Validation(tokens))
                {
                    Console.WriteLine("Invalid input");
                }
                int originalRow = int.Parse(tokens[1]);
                int originalCol = int.Parse(tokens[2]);
                int affectedRow = int.Parse(tokens[3]);
                int affectedCol = int.Parse(tokens[4]);
                if (IndexValidation(matrix, originalRow, originalCol, affectedRow, affectedCol))
                {
                    ElementShuffle(originalRow, originalCol, affectedRow, affectedCol, matrix);
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Input is invalid");
                }
            }
        }

        private static void ElementShuffle(int originalRow, int originalCol, int affectedRow, int affectedCol, string[][] matrix)
        {
            var originalIndex = matrix[originalRow][originalCol];
            var indexToExchange = matrix[affectedRow][affectedCol];
            matrix[originalRow][originalCol] = indexToExchange;
            matrix[affectedRow][affectedCol] = originalIndex;
        }

        private static void PrintMatrix(string[][] matrix)
        {
            foreach (var element in matrix)
            {
                Console.WriteLine(String.Join(" ", element));
            }
        }
        private static void FillingMatrix(string[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input == null)
                {
                    Console.WriteLine("Input is invalid");
                    return;
                }
                matrix[i] = new string[input.Length];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = input[j];
                }
            }
        }
        private static bool Validation(string[] tokens)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == null)
                {
                    return false;
                }
            }
            return true;
        }
        private static bool IndexValidation(string[][] matrix, int originalRow, int originalCol, int targetedRow, int targetedCol)
        {
            return originalRow >= 0 && originalRow < matrix.Length && originalCol >= 0 && originalCol < matrix[originalRow].Length && targetedRow >= 0 && targetedRow < matrix.Length && targetedCol >= 0 && targetedCol < matrix[targetedRow].Length;
        }
    }
}