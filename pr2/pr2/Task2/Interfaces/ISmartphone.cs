using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task2.Interfaces
{
    public interface ISmartphone
    {
        string Name { get; }
        float Price {  get; }
        void Info();
    }
}
