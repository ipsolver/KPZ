using pr2.Task1;

namespace pr2.Task1
{
    public class WebSite : SubscribtionFactory
    {
        public override Subscribtion CreateSubscribtion(string type)
        {
            Console.WriteLine("Створення підписки через сайт");
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