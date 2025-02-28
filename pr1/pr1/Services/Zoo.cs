using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Services
{
    using pr1.Models;
    using System;
    using System.Collections.Generic;

    public class Zoo : IZooReport
    {
        private List<IAnimal> animals = new List<IAnimal>();
        private List<Enclosure> enclosures = new List<Enclosure>();
        private List<Staff> workers = new List<Staff>();

        public void AddAnimal(IAnimal animal) 
        {
            animals.Add(animal); 
        }
        public void AddEnclosure(Enclosure enclosure)
        {
            enclosures.Add(enclosure);
        }
        public void AddEmployee(Staff employee)
        {
            workers.Add(employee);
        }

        public void GenerateReport()
        {
            Console.WriteLine("\n--- Zoo Report ---");

            Console.WriteLine("\nAnimals:");
            if (animals.Count == 0)
            { 
                Console.WriteLine("Немає тварин"); 
            }
            foreach (var animal in animals)
            {
                Console.WriteLine($" - {animal}");
            }

            Console.WriteLine("\nEnclosures:");
            if (enclosures.Count == 0)
            {
                Console.WriteLine("Немає вольєрів");
            }
            foreach (var enclosure in enclosures)
            {
                Console.WriteLine($" - {enclosure}");
            }

            Console.WriteLine("\nWorkers:");
            if (workers.Count == 0)
            {
                Console.WriteLine("Немає працівників");
            }
            foreach (var employee in workers)
            {
                Console.WriteLine($" - {employee}");
            }
        }
    }
}
