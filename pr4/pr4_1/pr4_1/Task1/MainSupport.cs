using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace pr4_1.Task1
{
    class MainSupport : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("\nЗагальні питання");
            Console.WriteLine("1 - Як перевірити баланс?");
            Console.WriteLine("2 - Як змінити часовий пояс?");
            Console.WriteLine("3 - Налаштування тарифу");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Щоб перевірити баланс, наберіть *111#");
                    return true;
                case "2":
                    Console.WriteLine("Змінити часовий пояс можна в налаштуваннях");
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
