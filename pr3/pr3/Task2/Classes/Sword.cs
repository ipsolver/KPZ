using pr3.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task2.Classes
{
    class Sword : InventoryDecorator
    {
        public Sword(ICharacter character) : base(character) 
        {
        }
        public override string Info() => character.Info() + " with sword";
        public override int GetPower() => character.GetPower() + 5;

    }
}
