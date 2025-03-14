using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task1
{
    public class PremiumSubscription: Subscribtion
    {
        public PremiumSubscription()
        {
            this.Name = "Premium";
            this.minimum=31;
            this.cost=160;
            this.advertisement=false;
            this.chanels = new List<string> { "QTV", "Animestar", "1+1", "Sport", "Top films", "Premium", "Historical", "Netflix", "Youtube", "MAX", "University" };
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
