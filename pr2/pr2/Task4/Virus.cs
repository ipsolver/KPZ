using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr2.Task4
{
    public class Virus : ICloneable
    {
        public float masa { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<Virus> children { get; set; }
        public Virus(float masa, int age, string name, string type)
        {
            this.masa=masa;
            this.age=age;
            this.name=name;
            this.type=type;
            children = new List<Virus>();
        }
        public void AddChild(Virus child)
        {
            children.Add(child);
        }
        public void Show(int level=0)
        {
            Console.WriteLine($"{new string('=', level * 2)}> {name} ({type}), Вік: {age}, Вага: {masa}");
            foreach (var child in children)
            {
                child.Show(level + 1);
            }
        }
        public object Clone()
        {
            Virus copy = (Virus)this.MemberwiseClone();
            copy.children = new List<Virus>();

            foreach (var child in this.children)
            {
                copy.children.Add((Virus)child.Clone());
            }

            return copy;
        }
    }
}
