using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private readonly TextDocument _document = new TextDocument();
        private readonly Stack<TextDocument.Memento> _history = new Stack<TextDocument.Memento>();

        public void Write(string text)
        {
            _history.Push(_document.Save());
            _document.Write(text);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Restore(memento);
            }
            else
            {
                Console.WriteLine("Nothing to undo!");
            }
        }

        public void Show()
        {
            Console.WriteLine($"Content: \"{_document}\"");
        }
    }
}
