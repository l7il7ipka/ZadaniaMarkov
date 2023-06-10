using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_18
{
    class Program
    {
        static void Main()
        {
            int m = 0, n = 0;
            try
            {
                Console.Write("Введите столбцы: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите строки: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка. Вы ввели не число!");
                Main();
            }
            Random rnd = new Random();
            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-10, 11);
                }
            }
            PrintArrayBorder(array);
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

        static void PrintArrayBorder(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
