using pr3.Task3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task3.Classes
{
    class Triangle : Shape
    {
        public Triangle(IRender render) : base(render)
        {
        }

        public override void Draw()
        {
            render.Render("Triangle");
        }
    }
}
