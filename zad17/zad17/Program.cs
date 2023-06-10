using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad17
{
    class Program
    {
        static void Main()
        {
            int number = 0, a;
            try
            {
                Console.Write("Введите натуральное число: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка. Вы ввели не число!");
                Main();
            }
            int[] digits = GetDigits(number);
            Array.Sort(digits);

            int minNumber = BuildNumber(digits);

            Console.WriteLine("Минимальное число: " + minNumber);
            Console.Write("Еще раз?(1-да,0-нет): ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        static int[] GetDigits(int number)
        {
            List<int> digitList = new List<int>();

            while (number > 0)
            {
                int digit = number % 10;
                digitList.Add(digit);
                number /= 10;
            }

            digitList.Reverse();

            return digitList.ToArray();
        }

        static int BuildNumber(int[] digits)
        {
            int result = 0;

            int leadingZeros = 0;
            foreach (int digit in digits)
            {
                if (digit == 0)
                    leadingZeros++;
                else
                    break;
            }

            if (leadingZeros > 0)
            {
                int[] nonZeroDigits = digits.Skip(leadingZeros).ToArray();
                result = BuildNumber(nonZeroDigits);
                for (int i = 0; i < leadingZeros; i++)
                {
                    result = result * 10;
                }
            }
            else
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    result = result * 10 + digits[i];
                }
            }

            return result;
        }
    }
}
