using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Runway : Component
    {
        public string Name { get; }
        public bool IsAvailable { get; private set; } = true;

        public Runway(string name)
        {
            Name = name;
        }

        public void Accept()
        {
            IsAvailable = false;
            Busy();
        }

        public void Release()
        {
            IsAvailable = true;
            Free();
        }

        private void Busy() => Console.WriteLine($"Runway {Name} is busy now!");
        private void Free() => Console.WriteLine($"Runway {Name} is free now  =)");
    }
}
