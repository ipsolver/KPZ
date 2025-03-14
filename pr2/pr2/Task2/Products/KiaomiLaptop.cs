using pr2.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr2.Task2
{
    public class KiaomiLaptop : ILaptop
    {
        public string Name { get; private set; }
        public float Price { get; private set; }

        public KiaomiLaptop()
    {
            Price=25000;
            Name="Kiaomi laptop";
    }
    public void Info()
    {
        Console.WriteLine($"Its {Name} and cost = {Price}");
    }


}
}
