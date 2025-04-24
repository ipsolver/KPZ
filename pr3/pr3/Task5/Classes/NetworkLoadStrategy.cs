using pr3.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task5.Classes
{
    public class NetworkLoadStrategy : ILoadStrategy
    {
        public string Load(string href)
        {
            return $"Image from URL: {href}";
        }
    }
}
