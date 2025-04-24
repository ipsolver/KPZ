using Memento;
using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();

            editor.Write("My ");
            editor.Show();

            editor.Write("editor");
            editor.Show();

            Console.WriteLine("Undoing...");
            editor.Undo();
            editor.Show();

            editor.Write("lab");
            editor.Show();
        }
    }
}
