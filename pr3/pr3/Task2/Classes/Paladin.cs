﻿using pr3.Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task2.Classes
{
    public class Paladin : ICharacter
    {
        public string Info() => "Paladin";
        public int GetPower() => 10;
    }
}
