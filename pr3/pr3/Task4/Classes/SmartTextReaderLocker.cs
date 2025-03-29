using pr3.Task4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pr3.Task4.Classes
{
    class SmartTextReaderLocker : ITextReader
    {
        private SmartTextReader reader;
        private string restriction;

        public SmartTextReaderLocker(string file, string restriction)
        {
            this.reader = new SmartTextReader(file);
            this.restriction = restriction;
        }

        public char[][] Reading()
        {
            if (Regex.IsMatch(this.reader.FilePath, restriction))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }

            return reader.Reading();
        }
    }
}
