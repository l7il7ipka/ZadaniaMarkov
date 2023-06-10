using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad19
{
class Program
    {
        static void Main()
        {
            int size = 0;
            try
            {
                Console.Write("Введите размерность квадратной матрицы: ");
                size = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка. Вы ввели не число!");
                Main();
            }
            int[,] matrix = new int[size, size];

            FillDiagonals(matrix);

            Console.WriteLine("Заполненная матрица:");
            PrintMatrix(matrix);
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

        static void FillDiagonals(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = i;
                matrix[i, size - i - 1] = size - i - 1;
            }
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
    }
}
