using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Models
{
    using pr1.Models;
    using System;
    using System.Collections.Generic;

    public class Enclosure
    {
        public string Type { get; private set; }
        public int Capacity { get; private set; }
        private List<IAnimal> Animals { get; }

        public Enclosure(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            if (Animals.Count >= Capacity)
                throw new InvalidOperationException("Enclosure is full!");

            Animals.Add(animal);
            Console.WriteLine($"{animal.Name} was added to enclosure {Type}.");
        }

        public void ListAnimals()
        {
            Console.WriteLine($"\nAnimals in {Type} enclosure:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"- {animal.Name} ({animal.Species})");
            }
        }

        public override string ToString()
        {
            return $"Enclosure: {Type}, Capacity: {Capacity}, Animal count: {Animals.Count}";
        }
    }
}

