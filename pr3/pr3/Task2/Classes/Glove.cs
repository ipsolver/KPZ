using pr3.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task2.Classes
{
    internal class Glove : InventoryDecorator
    {
        public Glove(ICharacter character) : base(character)
        {
        }

        public override string Info() => character.Info() + " with glove";
        public override int GetPower() => character.GetPower() + 4;
    }
}
