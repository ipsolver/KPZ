using pr2.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task5
{
    public class Character: ICharacter
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();


        public void Info()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($" Height: {Height}, Building: {Build}, Hair Color: {HairColor}, Eye Color: {EyeColor}, " +
                   $"Clothing: {Clothing}, Inventory: {string.Join(", ", Inventory)}");
        }
    }
}
