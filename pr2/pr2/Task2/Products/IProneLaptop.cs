using pr2.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task2
{
    public class IProneLaptop : ILaptop
    {
        public string Name { get; private set; }
        public float Price { get; private set; }
        public IProneLaptop()
        {
            Price=25000;
            Name="IProne laptop";
        }
        public void Info()
        {
            Console.WriteLine($"Its {Name} and cost = {Price}");
        }
    }
}
