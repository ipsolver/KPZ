using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task6.Classes
{
    public class LightHTMLMaster
    {
        private readonly LightElementFactory factory = new();

        public LightElementNode ProcessText(string text)
        {
            var master = new LightElementNode(factory.GetElementProperties("div", true, false));
            var lines = text.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd();
                LightElementProperties props;

                if (i == 0)
                    props = factory.GetElementProperties("h1", true, false);
                else if (char.IsWhiteSpace(lines[i][0]))
                    props = factory.GetElementProperties("blockquote", true, false);
                else if (line.Length < 20)
                    props = factory.GetElementProperties("h2", true, false);
                else
                    props = factory.GetElementProperties("p", true, false);

                var element = new LightElementNode(props);
                element.AppendChild(new LightTextNode(line));
                master.AppendChild(element);
            }
            return master;
        }
    }
}
