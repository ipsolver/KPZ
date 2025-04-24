using pr3.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3.Task5.Classes
{
    public class LightElementNode : LightNode
    {
        private Dictionary<string, List<IEventListener>> eventListeners = new();
        private string TagName { get; }
        private bool IsBlock { get; }
        private bool IsSelfClosing { get; }
        private List<string> CssClasses { get; }
        private List<LightNode> children;

        public LightElementNode(string tagName, bool isBlock = true, bool isSelfClosing = false)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            children = new List<LightNode>();
        }

        public void AddClass(string Сlass)
        {
            CssClasses.Add(Сlass);
        }
        public void AppendChild(LightNode one)
        {
            if (IsSelfClosing)
                throw new InvalidOperationException("Self-closing tags cannot have children!");

            children.Add(one);
        }


        public override string GetInner()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in children)
            {
                sb.Append(child.Render());
            }
            return sb.ToString();
        }



        public override string Render()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<{TagName}");

            if (CssClasses.Count > 0)
            {
                sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");
            }

            if (IsSelfClosing)
            {
                sb.Append(" />\n");
            }
            else
            {
                sb.Append($">{GetInner()}</{TagName}>\n");
            }

            return sb.ToString();
        }

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] = new List<IEventListener>();
            }
            eventListeners[eventType].Add(listener);
        }

        private void Notify(string eventType)
        {
            if (eventListeners.TryGetValue(eventType, out var listeners))
            {
                foreach (var listener in listeners)
                {
                    listener.HandleEvent(eventType, this);
                }
            }
        }

        public void Click()
        {
            Console.WriteLine($"[CLICK] on <{TagName}>");
            Notify("click");
        }

        public void MouseOver()
        {
            Console.WriteLine($"[MOUSEOVER] on <{TagName}>");
            Notify("mouseover");
        }

    }
}
