using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Component
    {
        protected IAirTrafficMediator? _mediator;

        public void SetMediator(IAirTrafficMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
