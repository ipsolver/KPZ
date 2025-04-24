using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr3.Task5.Classes;

namespace pr3.Task5.Interfaces
{
    public interface IEventListener
    {
        void HandleEvent(string eventType, LightElementNode sender);
    }
}
