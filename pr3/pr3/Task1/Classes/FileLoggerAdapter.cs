using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr3.Task1.Classes;
using pr3.Task1.Interfaces;

namespace pr3.Task1
{
    public class FileLoggerAdapter : ILogger
    {
        private FileWriter _filer;

        public FileLoggerAdapter(string file)
        {
            _filer = new FileWriter(file);
        }

        public void Log(string text)
        {
            _filer.WriteLine("!!![INFO]: " + text);
        }

        public void Error(string text)
        {
            _filer.WriteLine("!!![ERROR]: " + text);
        }

        public void Warn(string text)
        {
            _filer.WriteLine("!!![WARN]: " + text);
        }
    }
}
