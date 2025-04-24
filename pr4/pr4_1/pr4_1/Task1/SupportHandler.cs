using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_1.Task1
{
    abstract class SupportHandler
    {
        protected SupportHandler next;

        public SupportHandler SetNext(SupportHandler next)
        {
            this.next = next;
            return next;
        }

        public abstract bool Handle();
    }
}
