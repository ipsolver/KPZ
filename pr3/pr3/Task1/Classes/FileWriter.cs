using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task1.Classes
{
    public class FileWriter
    {
        private string file;

        public FileWriter(string file)
        {
            this.file = file;
        }
        public void Write(string text) 
        {
            File.AppendAllText(file, text);
        }
        public void WriteLine(string text)
        {
            try
            {
                File.AppendAllText(file, text + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка запису у файл: " + ex.Message);
            }
        }

    }
}
