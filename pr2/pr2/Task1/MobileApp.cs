using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task1
{
    public class MobileApp : SubscribtionFactory
    {
        public override Subscribtion CreateSubscribtion(string type)
        {
            Console.WriteLine("Створення підписки через додаток");
            return type switch
            {
                "Premium" => new PremiumSubscription(),
                "Educational" => new EducationalSubscription(),
                "Domestic" => new DomesticSubscription(),
                _ => throw new ArgumentException("Невідомий тип підписки"),
            };
        }
    }
}
