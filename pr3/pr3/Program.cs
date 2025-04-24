using pr3.Task2.Interfaces;
using pr3.Task2.Classes;
using pr3.Task1.Interfaces;
using pr3.Task2;
using pr3.Task1;
using pr3.Task3.Classes;
using pr3.Task3.Interfaces;
using pr3.Task4.Classes;
using pr3.Task4.Interfaces;
using pr3.Task5.Classes;
namespace pr3
{
    class Program
    {
        static void Main()
        {
            //Завдання 1
            ILogger consoleLogger = new Logger();
            consoleLogger.Log("Це консольне логування");
            consoleLogger.Error("Це помилка в консолі");
            consoleLogger.Warn("Це попередження в консолі");

            string file = "../../../logger.txt";
            ILogger fileLogger = new FileLoggerAdapter(file);
            fileLogger.Log("Файловий запис логування");
            fileLogger.Error("Файловий запис помилки");
            fileLogger.Warn("Файловий запис попередження");

            Console.WriteLine("Логування завершено!");

            //Завдання 2
            ICharacter warrior = new Warrior();
            Console.WriteLine($"{warrior.Info()} - Power: {warrior.GetPower()}");

            warrior = new Glove(warrior);
            Console.WriteLine($"{warrior.Info()} - Power: {warrior.GetPower()}");

            warrior = new Sword(warrior);
            Console.WriteLine($"{warrior.Info()} - Power: {warrior.GetPower()}");

            Console.WriteLine("\n--- Інший герой ---\n");
            ICharacter mage = new Mage();
            Console.WriteLine($"{mage.Info()} - Power: {mage.GetPower()}");
            
            mage = new Amulet(mage);
            Console.WriteLine($"{mage.Info()} - Power: {mage.GetPower()}");
            
            Console.WriteLine("\n--- Інший герой ---\n");
            ICharacter paladin = new Paladin();
            Console.WriteLine($"{paladin.Info()} - Power: {paladin.GetPower()}");

            paladin = new Sword(paladin);
            Console.WriteLine($"{paladin.Info()} - Power: {paladin.GetPower()}");

            //Завдання 3
            Console.WriteLine("\nУ векторній графіці\n");
            IRender vectorRender = new VectorRender();
            Shape circle = new Circle(vectorRender);
            Shape square = new Square(vectorRender);
            Shape triangle = new Triangle(vectorRender);

            circle.Draw();
            square.Draw();
            triangle.Draw();

            Console.WriteLine("\nВ растровій графіці\n");

            IRender rasterRenderer = new RasterRender();
            circle = new Circle(rasterRenderer);
            square = new Square(rasterRenderer);
            triangle = new Triangle(rasterRenderer);

            circle.Draw();
            square.Draw();
            triangle.Draw();

            //Завдання 4
            string test = "../../../test.txt";
            string secret = "../../../secret_file.txt";
            System.IO.File.WriteAllText(test, "This is very weird test");
            System.IO.File.WriteAllText(secret, "Top Secret Data");

            Console.WriteLine("\nSmartTextReader:");
            ITextReader reader = new SmartTextReader(test);
            reader.Reading();

            Console.WriteLine("\nSmartTextChecker:");
            ITextReader checker = new SmartTextChecker(test);
            checker.Reading();

            Console.WriteLine("\nSmartTextReaderLocker:");
            ITextReader locker1 = new SmartTextReaderLocker(test, "secret");
            ITextReader locker2 = new SmartTextReaderLocker(secret, "secret");

            Console.WriteLine("\nTrying allowed file:");
            locker1.Reading();

            Console.WriteLine("\nTrying restricted file:");
            locker2.Reading();






            //Завдання 5

            LightElementNode div = new LightElementNode("div");
            div.AddClass("container");

            LightElementNode header = new LightElementNode("h1", isBlock: true);
            header.AppendChild(new LightTextNode("Hello!"));
            div.AppendChild(header);

            LightElementNode ul = new LightElementNode("ul");
            ul.AddClass("list");

            for (int i = 1; i <= 5; i++)
            {
                LightElementNode li = new LightElementNode("li", isBlock: false);
                li.AppendChild(new LightTextNode($"Its item of list"));
                ul.AppendChild(li);
            }

            div.AppendChild(ul);

            Console.WriteLine("\nLightHTML Output:");
            Console.WriteLine(div.Render());
            ////////////////////////////////////////////////////////////////

            var image1 = new LightImageNode("images/photo.png");
            var image2 = new LightImageNode("https://example.com/image.jpg");

            Console.WriteLine(image1.Render());
            Console.WriteLine(image2.Render());



            //Завдання 6

            string contenter = "../../../content.txt";
            if (!File.Exists(contenter))
            {
                Console.WriteLine("Файл content.txt не знайдено!");
                return;
            }

            string text = File.ReadAllText(contenter);
            var master = new pr3.Task6.Classes.LightHTMLMaster();
            var page = master.ProcessText(text);

            Console.WriteLine(page.Render());
            Console.WriteLine($"Використано пам'яті: {GC.GetTotalMemory(true)} байт");





        }
    }
}