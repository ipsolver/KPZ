using pr3.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task5.Classes
{
    internal class LightImageNode : LightNode
    {
        public string Src { get; }
        private ILoadStrategy loader;

        public LightImageNode(string src)
        {
            Src = src;
            loader = ChooseStrategy(src);
        }

        private ILoadStrategy ChooseStrategy(string href)
        {
            if (href.StartsWith("http"))
                return new NetworkLoadStrategy();
            return new FileLoadStrategy();
        }

        public override string Render()
        {
            return $"<img src=\"{Src}\" alt=\"{loader.Load(Src)}\" />\n";
        }

        public override string GetInner() => string.Empty;
    }
}
