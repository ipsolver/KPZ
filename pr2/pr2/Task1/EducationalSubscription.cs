using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task1
{
    public class EducationalSubscription: Subscribtion
    {
        public EducationalSubscription()
        {
            this.Name = "Educational";
            this.minimum=25;
            this.cost=80;
            this.advertisement=false;
            this.chanels = new List<string> { "Historical", "Netflix", "Youtube", "MAX", "University" };
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
