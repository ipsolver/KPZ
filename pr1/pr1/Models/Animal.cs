namespace pr1.Models.Animals
{
    public class Animal : IAnimal
    {
        public string Name { get; private set; }
        public string Species { get; private set; }
        public double Weight { get; private set; }
        public string PreferredFoodType { get; private set; }
        private string Sound { get; set; }

        public Animal(string name, string species, double weight, string preferredFoodType, string sound)
        {
            Name = name;
            Species = species;
            Weight = weight;
            PreferredFoodType = preferredFoodType;
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} ({Species}) видає звук: {Sound}");
        }

        public void Feed(Food food)
        {
            if (food.Type == PreferredFoodType)
                Console.WriteLine($"{Name} ({Species}) їсть {food.Name}.");
            else
                Console.WriteLine($"{Name} ({Species}) не їсть {food.Name}! Він/вона їсть {PreferredFoodType}.");
        }
        public override string ToString()
        {
            return $"{Name} - ({Species}), Вага: {Weight} кг, Їжа: {PreferredFoodType}";
        }
    }
}
