using pr3.Task4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task4.Classes
{
    internal class SmartTextChecker : ITextReader
    {
        private readonly SmartTextReader reader;
        private readonly string file;

        public SmartTextChecker(string file)
        {
            this.file = file;
            this.reader = new SmartTextReader(file);
        }

        public char[][] Reading()
        {
            Console.WriteLine($"Opening the file: {file}");
            char[][] content = reader.Reading();
            Console.WriteLine($"Successfully read {content.Length} lines, {content.Sum(line => line.Length)} characters");
            Console.WriteLine($"Closing file: {file}");
            return content;
        }
    }
}
