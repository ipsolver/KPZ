using pr4_1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace pr4_1.Task1
{
    class TariffSupport : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("\nНалаштування тарифу");
            Console.WriteLine("1 - Доступні тарифи");
            Console.WriteLine("2 - Як змінити тариф?");
            Console.WriteLine("3 - Технічна підтримка");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("У нас є тарифи: 'Сімейний', 'Максимальний', 'Студентський'");
                    return true;
                case "2":
                    Console.WriteLine("Щоб змінити тариф, скористайтеся додатком або *123#");
                    return true;
                case "3":
                    return next?.Handle() ?? false;
                default:
                    Console.WriteLine("Неправильний вибір!");
                    return false;
            }
        }
    }
}
