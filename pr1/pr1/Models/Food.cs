using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Models
{
    public class Food
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Food(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} ({Type})";
        }
    }
}

