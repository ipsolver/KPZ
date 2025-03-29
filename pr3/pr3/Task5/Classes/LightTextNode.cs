using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace pr3.Task5.Classes
{
    public class LightTextNode : LightNode
    {
        public string text { get; }

        public LightTextNode(string text)
        {
            this.text = text;
        }

        public override string Render() => text;
        public override string GetInner()
        {
            return text;
        }
    }
}
