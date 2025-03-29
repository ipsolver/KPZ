using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task1.Interfaces
{
    interface ILogger
    {
        void Log(string text);
        void Error(string text);
        void Warn(string text);
    }
}
