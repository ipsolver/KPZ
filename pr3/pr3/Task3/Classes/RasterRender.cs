using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr3.Task3.Interfaces;

namespace pr3.Task3.Classes
{
    internal class RasterRender : IRender
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as pixels");
        }
    }
}
