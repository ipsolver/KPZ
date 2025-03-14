using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace pr2.Task1
{
    public class DomesticSubscription: Subscribtion
    {
        public DomesticSubscription()
        {
            this.Name = "Domestic";
            this.minimum = 20;
            this.cost = 100;
            this.advertisement = true;
            this.chanels = new List<string> { "1+1", "Netflix", "Youtube", "MAX" };
        }
        public override void DoPayment()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Ви оплатили {Name} підписку терміном на {minimum} днів");
            Console.WriteLine($"Вартість {Name} підписки: {cost} грн");
            Console.WriteLine("Доступні канали:");
            Console.WriteLine(string.Join(", ", chanels));
        }
    }
}
