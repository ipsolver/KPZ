using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using pr3.Task1.Interfaces;

namespace pr3.Task1
{
    public class Logger : ILogger
    {
        public void Log(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!!![LOG]: " + str);
            Console.ResetColor();

        }
        public void Error(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!![ERROR]: " + str);
            Console.ResetColor();
        }
        public void Warn(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("!!![WARN]: " + str);
            Console.ResetColor();
        }
    }
}
