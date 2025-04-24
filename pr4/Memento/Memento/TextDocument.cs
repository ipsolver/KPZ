using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocument
    {
        public string Content { get; private set; } = "";

        public void Write(string text)
        {
            Content += text;
        }

        public void Erase()
        {
            Content = "";
        }

        public override string ToString() => Content;

        public class Memento
        {
            internal string State { get; }

            internal Memento(string state)
            {
                State = state;
            }
        }

        public Memento Save() => new Memento(Content);

        public void Restore(Memento memento)
        {
            Content = memento.State;
        }
    }
}
