using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task6.Classes
{
    public class LightElementFactory
    {
        private readonly Dictionary<string, LightElementProperties> _cache = new();

        public LightElementProperties GetElementProperties(string tagName, bool isBlock, bool isSelfClosing)
        {
            string key = $"{tagName}_{isBlock}_{isSelfClosing}";
            if (!_cache.ContainsKey(key))
            {
                _cache[key] = new LightElementProperties(tagName, isBlock, isSelfClosing);
            }
            return _cache[key];
        }
    }
}
