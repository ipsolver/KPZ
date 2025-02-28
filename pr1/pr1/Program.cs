using System;
using pr1.Models;
using pr1.Services;
using pr1.Models.Animals;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Zoo zoo = new Zoo();

        Food meat = new Food("Яловичина", "Meat");
        Food seeds = new Food("Насіння", "Seeds");

        IAnimal ryk = AnimalFactory.CreateAnimal("Ryk", "Lion", 150, "Meat", "Rrrr");
        IAnimal toto = AnimalFactory.CreateAnimal("Toto", "Down_chicken", 1.2, "Seeds", "Tuh-tuh");

        var savanna = new Enclosure("Savannah", 5);
        savanna.AddAnimal(ryk);

        var birdHouse = new Enclosure("Bird House", 3);
        birdHouse.AddAnimal(toto);

        var keeper = new Staff("Dan", "Cleaner", 2500);

        zoo.AddAnimal(ryk);
        zoo.AddAnimal(toto);
        zoo.AddEnclosure(savanna);
        zoo.AddEnclosure(birdHouse);
        zoo.AddEmployee(keeper);

        savanna.ListAnimals();
        birdHouse.ListAnimals();

        Console.WriteLine("\nГодуємо тварин...");
        ryk.Feed(meat);
        toto.Feed(seeds);
        toto.Feed(meat);

        zoo.GenerateReport();
    }
}
