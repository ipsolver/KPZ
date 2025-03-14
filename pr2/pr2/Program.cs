using pr2.Task1;
using pr2.Task2;
using pr2.Task2.Classes;
using pr2.Task2.Interfaces;
using pr2.Task3;
using pr2.Task4;
using pr2.Task5.Classes;
using pr2.Task5;
using System;
using System.Text;
using pr2.Task5.Interfaces;

namespace pr2
{
    class Program
    {
        static void Main()
        {
            //Task1
            SubscribtionFactory webSite = new WebSite();
            SubscribtionFactory mobileApp = new MobileApp();
            SubscribtionFactory managerCall = new ManagerCall();

            Subscribtion domestic = webSite.CreateSubscribtion("Domestic");
            Subscribtion educational = mobileApp.CreateSubscribtion("Educational");
            Subscribtion premium = managerCall.CreateSubscribtion("Premium");

            domestic.DoPayment();
            educational.DoPayment();
            premium.DoPayment();
            Console.WriteLine("--------------------------------");

            //Task2
            IDeviceFactory iproneFactory = new IProneFactory();
            IDeviceFactory kiaomiFactory = new KiaomiFactory();
            IDeviceFactory balaxyFactory = new BalaxyFactory();
            Console.WriteLine("IProne магазин:");
            ILaptop iproneLaptop = iproneFactory.CreateLaptop();
            iproneLaptop.Info();
            ISmartphone iproneSmartphone = iproneFactory.CreateSmartphone();
            iproneSmartphone.Info();
            INetbook iproneNetbook = iproneFactory.CreateNetbook();
            iproneNetbook.Info();
            IEBook iproneEbook = iproneFactory.CreateEBook();
            iproneEbook.Info();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Kiaomi магазин:");
            ILaptop kiaomiLaptop = kiaomiFactory.CreateLaptop();
            kiaomiLaptop.Info();
            ISmartphone kiaomiSmartphone = kiaomiFactory.CreateSmartphone();
            kiaomiSmartphone.Info();
            INetbook kiaomiNetbook = kiaomiFactory.CreateNetbook();
            kiaomiNetbook.Info();
            IEBook kiaomiEbook = kiaomiFactory.CreateEBook();
            kiaomiEbook.Info();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Balaxy магазин:");
            ILaptop balaxyLaptop = balaxyFactory.CreateLaptop();
            balaxyLaptop.Info();
            ISmartphone balaxySmartphone = balaxyFactory.CreateSmartphone();
            balaxySmartphone.Info();
            INetbook balaxyNetbook = balaxyFactory.CreateNetbook();
            balaxyNetbook.Info();
            IEBook balaxyEbook = balaxyFactory.CreateEBook();
            balaxyEbook.Info();

            Console.WriteLine("--------------------------------");
            //Task 3
            Authenticator user1 = Authenticator.Instance;
            user1.Authenticate("user1", "my_password");
            Authenticator user2 = Authenticator.Instance;
            user2.Authenticate("user2", "your_password");
            Console.WriteLine($"Are user1 and user2 the same? {ReferenceEquals(user1, user2)}");
            
            Console.WriteLine("--------------------------------");
            //Task 4

            Virus grandparent = new Virus(2.0f, 10, "VirusA", "TypeA" );

            Virus parent1 = new Virus(1.5f, 6, "VirusB1", "TypeB");
            Virus parent2 = new Virus(2.8f, 7, "VirusB2", "TypeB");
            grandparent.AddChild(parent1);
            grandparent.AddChild(parent2);

            Virus child1 = new Virus(1.2f, 3, "VirusC1", "TypeC");
            Virus child2 = new Virus(0.5f, 1, "VirusC2", "TypeC");
            Virus child3 = new Virus(1.1f, 4, "VirusC3", "TypeC");
            parent1.AddChild(child1);
            parent1.AddChild(child2);
            parent2.AddChild(child3);

            Console.WriteLine("Оригінальне сімейство вірусів:");
            grandparent.Show();

            Virus clonedFamily = (Virus)grandparent.Clone();

            Console.WriteLine("\nКлоноване сімейство вірусів:");
            clonedFamily.Show();

            clonedFamily.name = "Clone-VirusA";
            clonedFamily.children[0].name = "Clone-VirusB1";
            clonedFamily.children[1].name = "Clone-VirusB2";

            Console.WriteLine("\nОригінальне сімейство вірусів (після змін у клонованому):");
            grandparent.Show();
            Console.WriteLine("\nКлоноване сімейство вірусів (після змін у клонованому):");
            clonedFamily.Show();

            Console.WriteLine("--------------------------------");
            //Task 5

            ICharacterBuilder heroBuilder = new HeroBuilder();
            CharacterDirector director = new CharacterDirector(heroBuilder);

            ICharacter hero = director.CreateHero(heroBuilder);
            Console.WriteLine("Герой:");
            hero.Info();

            Console.WriteLine("--------------------------------");

            ICharacterBuilder enemyBuilder = new EnemyBuilder();
            director = new CharacterDirector(enemyBuilder);

            ICharacter enemy = director.CreateEnemy(enemyBuilder);
            Console.WriteLine("Ворог:");
            enemy.Info();



        }
    }
}
