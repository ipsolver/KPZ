using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task6.Classes
{
    public class LightElementNode : LightNode
    {
        private LightElementProperties Properties { get; }
        private List<string> CssClasses { get; } = new List<string>();
        private List<LightNode> children { get; } = new List<LightNode>();

        public LightElementNode(LightElementProperties properties)
        {
            Properties = properties;
        }

        public void AddClass(string Сlass)
        {
            CssClasses.Add(Сlass);
        }
        public void AppendChild(LightNode one)
        {
            if (Properties.IsSelfClosing)
                throw new InvalidOperationException("Self-closing tags cannot have children!");

            children.Add(one);
        }

        public override string GetInner()
        {
            StringBuilder sb = new();
            foreach (var child in children)
            {
                sb.Append(child.Render());
            }
            return sb.ToString();
        }

        public override string Render()
        {
            StringBuilder sb = new();
            sb.Append($"<{Properties.TagName}");

            if (CssClasses.Count > 0)
                sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");

            if (Properties.IsSelfClosing)
                sb.Append(" />\n");
            else
                sb.Append($">{GetInner()}</{Properties.TagName}>\n");

            return sb.ToString();
        }

    }
}
