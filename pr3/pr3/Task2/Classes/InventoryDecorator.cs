using pr3.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task2.Classes
{
    abstract class InventoryDecorator : ICharacter
    {
        protected ICharacter character;
        public InventoryDecorator(ICharacter character)
        {
            this.character = character;
        }

        public virtual string Info() => character.Info();
        public virtual int GetPower() => character.GetPower();
    }
}
