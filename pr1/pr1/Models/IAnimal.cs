using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Models
{
    public interface IAnimal
    {
        string Name { get; }
        string Species { get; }
        double Weight { get; }
        string PreferredFoodType { get; }
        void MakeSound();
        void Feed(Food food);
    }
}
