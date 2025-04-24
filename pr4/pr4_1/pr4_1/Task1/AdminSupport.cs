using pr4_1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_1.Task1
{
    class AdminSupport : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("\nАдміністратор");
            Console.WriteLine("1 - Скарга");
            Console.WriteLine("2 - Зв'язок із головним офісом");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            if (input == "1" || input == "2")
            {
                Console.WriteLine("Ваш запит зареєстровано! Дякуємо за звернення!");
                return true;
            }

            Console.WriteLine("Неправильний вибір!");
            return false;
        }
    }
}
