using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad15
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }
            Console.WriteLine("Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int[] modifiedArr = ModifyArray(arr);
            Console.WriteLine("Modified Array:");
            foreach (int num in modifiedArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
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

        static int[] ModifyArray(int[] arr)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (seen.ContainsKey(arr[i]))
                {
                    arr[i] *= i;
                    seen[arr[i]] = i; 
                }
                else
                {
                    seen[arr[i]] = i;
                }
            }

            return arr;
        }
    }
}
