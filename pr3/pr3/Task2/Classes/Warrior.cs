using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr3.Task2;
using pr3.Task2.Interfaces;

namespace pr3.Task2
{
    public class Warrior : ICharacter
    {
        public string Info() => "Warrior";
        public int GetPower() => 20;
    }
}
