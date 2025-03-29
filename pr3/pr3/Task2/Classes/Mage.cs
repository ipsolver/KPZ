using pr3.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task2
{
    public class Mage : ICharacter
    {
        public string Info() => "Mage";
        public int GetPower() => 15;
    }
}
