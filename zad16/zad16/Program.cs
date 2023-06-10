using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad16
{
    class Program
    {
        static void Main()
        {
            int[] arr = GenerateArray();
            int start = 0;
            int end = 0;
            int maxLength = 0;
            int currentStart = 0;
            int currentLength = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        start = currentStart;
                        end = i - 1;
                    }

                    currentStart = i;
                    currentLength = 1;
                }
            }
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                start = currentStart;
                end = arr.Length - 1;
            }
            int repeatedElement = arr[start];
            Console.WriteLine("Длина цепочки: {0}", end - start + 2);
            Console.WriteLine("Повторяющийся элемент: " + repeatedElement);
            Console.WriteLine("Начало цепочки: " + start);
            Console.WriteLine("Конец цепочки: " + end);
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
        static int[] GenerateArray()
        {
            int[] arr = new int[1000];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 7);
            }
            return arr;
        }
    }
}
