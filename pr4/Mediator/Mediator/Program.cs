using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCentre = new CommandCentre();

            var runway1 = new Runway("Runway 1");
            var runway2 = new Runway("Runway 2");

            var aircraft1 = new Aircraft("Boeing-777");
            var aircraft2 = new Aircraft("Boeing-333");

            commandCentre.RegisterRunway(runway1);
            commandCentre.RegisterRunway(runway2);

            commandCentre.RegisterAircraft(aircraft1);
            commandCentre.RegisterAircraft(aircraft2);

            aircraft1.RequestLanding();
            aircraft2.RequestLanding();

            aircraft1.TakeOff();
            aircraft2.TakeOff();
        }
    }
}