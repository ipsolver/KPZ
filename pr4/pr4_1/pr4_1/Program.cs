using pr4_1.Task1;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var main = new MainSupport();
        var tariff = new TariffSupport();
        var tech = new TechnicalSupport();
        var admin = new AdminSupport();

        main.SetNext(tariff).SetNext(tech).SetNext(admin);

        bool resolved = false;
        while (!resolved)
        {
            Console.WriteLine("\n Головне меню");
            Console.WriteLine("1 - Розпочати звернення");
            Console.WriteLine("2 - Вийти");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                resolved = main.Handle();

                if (!resolved)
                {
                    Console.WriteLine("\nПроблему не вирішено! Повертаємось до початку...\n");
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("Дякуємо за звернення! До побачення!");
                break;
            }
            else
            {
                Console.WriteLine("Неправильний вибір!");
            }
        }
    }
}