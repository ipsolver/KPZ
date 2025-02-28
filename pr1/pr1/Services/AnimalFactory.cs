using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Services
{
    using pr1.Models;
    using pr1.Models.Animals;

    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(string name, string species, double weight, string foodType, string sound)
        {
            return new Animal(name, species, weight, foodType, sound);
        }
    }
}

