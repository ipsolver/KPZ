using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Aircraft : Component
    {
        public string Name { get; }
        public bool IsTakingOff { get; private set; }

        public Aircraft(string name)
        {
            Name = name;
        }

        public void RequestLanding()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Aircraft {Name} is requesting landing");
            _mediator?.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Aircraft {Name} is taking off");
            IsTakingOff = true;
            _mediator?.RequestTakeOff(this);
            IsTakingOff = false;
        }
    }
}