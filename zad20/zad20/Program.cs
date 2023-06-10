using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad20
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = new int[3, 3];
            int maxValue = 9;

            FillDistinctNumbers(matrix, maxValue);

            Console.WriteLine("Массив:");
            PrintMatrix(matrix);

            bool isMagicSquare = CheckMagicSquare(matrix);
            Console.WriteLine("Является ли массив магическим квадратом: " + isMagicSquare);
            Console.Write("Еще раз?(1-да,0-нет): ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        static void FillDistinctNumbers(int[,] matrix, int maxValue)
        {
            int count = 0;
            Random random = new Random();

            while (count < maxValue)
            {
                int number = random.Next(1, maxValue + 1);

                if (!ContainsNumber(matrix, number))
                {
                    matrix[count / 3, count % 3] = number;
                    count++;
                }
            }
        }

        static bool ContainsNumber(int[,] matrix, int number)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == number)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static bool CheckMagicSquare(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                int colSum = 0;

                for (int j = 0; j < cols; j++)
                {
                    rowSum += matrix[i, j];
                    colSum += matrix[j, i];
                }

                if (rowSum != 15 || colSum != 15)
                {
                    return false;
                }
            }
            int mainDiagonalSum = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
            int antiDiagonalSum = matrix[0, 2] + matrix[1, 1] + matrix[2, 0];

            if (mainDiagonalSum != 15 || antiDiagonalSum != 15)
            {
                return false;
            }

            return true;
        }
    }
}
