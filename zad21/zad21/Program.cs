using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad21
{
    class Program
    {
        static void Main()
        {
            int m = 0, n = 0;
            try
            {
                Console.Write("Введите количество строк: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка. Вы ввели не число!");
                Main();
            }
            int[,] matrix = new int[m, n];
            FillMatrixSpiral(matrix);

            Console.WriteLine("Матрица:");
            PrintMatrix(matrix);
            Console.ReadLine();
        }

        static void FillMatrixSpiral(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            int value = 1;
            int rowStart = 0, rowEnd = m - 1;
            int colStart = 0, colEnd = n - 1;

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int col = colStart; col <= colEnd; col++)
                {
                    matrix[rowStart, col] = value;
                    value++;
                }
                rowStart++;
                for (int row = rowStart; row <= rowEnd; row++)
                {
                    matrix[row, colEnd] = value;
                    value++;
                }
                colEnd--;
                if (rowStart <= rowEnd)
                {
                    for (int col = colEnd; col >= colStart; col--)
                    {
                        matrix[rowEnd, col] = value;
                        value++;
                    }
                    rowEnd--;
                }

                if (colStart <= colEnd)
                {
                    for (int row = rowEnd; row >= rowStart; row--)
                    {
                        matrix[row, colStart] = value;
                        value++;
                    }
                    colStart++;
                }
            }
        }
        static void PrintMatrix(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
