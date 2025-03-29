using pr3.Task4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task4.Classes
{
    class SmartTextReader : ITextReader
    {
        protected string file;

        public string FilePath => file;
        public SmartTextReader(string file)
        {
            this.file = file;
        }

        public char[][] Reading()
        {
            string[] lines = File.ReadAllLines(this.file);
            char[][] result = lines.Select(line => line.ToCharArray()).ToArray();

            foreach (var line in result)
            {
                Console.WriteLine(new string(line));
            }

            return result;
        }
    }
}
