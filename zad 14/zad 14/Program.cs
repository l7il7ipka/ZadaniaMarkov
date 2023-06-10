using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_14
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите дату в формате дд.мм.гггг: ");
            string dateString = Console.ReadLine();
            DateTime date;
            if (DateTime.TryParse(dateString, out date))
            {
                string dayOfWeek = date.ToString("dddd");
                Console.WriteLine("День недели: {0}.", dayOfWeek);
            }
            else
            {
                Console.WriteLine("Ошибка. Некорректная дата.");
            }
            Console.Write("Еще раз?(1-да,0-нет) ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                Main();
            else
                Environment.Exit(0);
        }
    }
}
