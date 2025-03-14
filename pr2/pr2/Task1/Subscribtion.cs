using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task1
{
    public abstract class Subscribtion
    {
        public int cost { get; protected set; }
        public int minimum { get; protected set; }
        public List<string> chanels { get; protected set; }
        public bool advertisement { get; protected set; }
        public string Name { get; protected set; }
        public abstract  void DoPayment();
    }
}
