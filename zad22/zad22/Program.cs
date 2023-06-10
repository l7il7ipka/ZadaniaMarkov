using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad22
{
    class Program
    {
        static bool IsSymmetricMain(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                        return false;
                }
            }

            return true;
        }

        static bool IsSymmetricSecondary(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] != matrix[rows - j - 1, cols - i - 1])
                        return false;
                }
            }

            return true;
        }

        static void Main()
        {
            int n = 3;
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(1, 9);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool isSymmetricMain = IsSymmetricMain(matrix);
            bool isSymmetricSecondary = IsSymmetricSecondary(matrix);

            if (isSymmetricMain && isSymmetricSecondary)
            {
                Console.WriteLine("Матрица симметрична относительно главной и побочной диагонали.");
            }
            else if (isSymmetricMain)
            {
                Console.WriteLine("Матрица симметрична относительно главной диагонали.");
            }
            else if (isSymmetricSecondary)
            {
                Console.WriteLine("Матрица симметрична относительно побочной диагонали.");
            }
            else
            {
                Console.WriteLine("Матрица не является симметричной ни относительно главной, ни относительно побочной диагонали.");
            }
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
    }
}
