using pr2.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task2
{
    public class BalaxySmartphone : ISmartphone
    {
        public string Name { get; private set; }
        public float Price { get; private set; }
        public BalaxySmartphone()
        {
            Price=25000;
            Name="Balaxy smartphone";
        }
        public void Info()
        {
            Console.WriteLine($"Its {Name} and cost = {Price}");
        }
    }
}
