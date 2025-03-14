using pr2.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task2
{
    internal class IProneEBook : IEBook
    {
        public string Name { get; private set; }
        public float Price { get; private set; }
        public IProneEBook()
        {
            Price=15000;
            Name="IProne ebook";
        }
        public void Info()
        {
            Console.WriteLine($"Its {Name} and cost = {Price}");
        }
    }
}
