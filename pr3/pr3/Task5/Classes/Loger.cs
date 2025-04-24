using pr3.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr3.Task5.Interfaces;

namespace pr3.Task5.Classes
{
    public class Loger : IEventListener
    {
        private string _name;

        public Loger(string name)
        {
            _name = name;
        }

        public void HandleEvent(string eventType, LightElementNode sender)
        {
            Console.WriteLine($"{_name} is getting '{eventType}' event with [{sender.Render().Trim()}]");
        }
    }
}
