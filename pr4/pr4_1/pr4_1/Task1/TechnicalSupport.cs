using pr4_1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace pr4_1.Task1
{
    class TechnicalSupport : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("\nТехнічна підтримка");
            Console.WriteLine("1 - Проблема з інтернетом");
            Console.WriteLine("2 - Проблема зі зв'язком");
            Console.WriteLine("3 - Адміністрація");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "2":
                    Console.WriteLine("Будь ласка, перезавантажте пристрій. Якщо проблема не зникне — наберіть 020202");
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
