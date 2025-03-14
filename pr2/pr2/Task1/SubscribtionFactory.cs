using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task1
{
    public abstract class SubscribtionFactory
    {
        public abstract Subscribtion CreateSubscribtion(string type);
    }
}
