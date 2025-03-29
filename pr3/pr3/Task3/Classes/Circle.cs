using pr3.Task3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task3.Classes
{
    class Circle : Shape
    {
        public Circle(IRender render) : base(render) 
        {
        }

        public override void Draw()
        {
            render.Render("Circle");
        }
    }
}
