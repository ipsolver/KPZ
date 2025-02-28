# SOLID principles
<hr>

## Single Responsibility Principle
`The gist:` Each class has a single responsibility.

- [`Animal.cs`](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/Animal.cs) – is only responsible for storing data about the animal and its behavior.
- [`Zoo.cs`](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Services/Zoo.cs) – is only responsible for managing the zoo.
- [`Enclosure.cs`](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/Enclosure.cs) – is only responsible for managing the enclosures.
- [`Food.cs`](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/Food.cs) – stores information about food, but does not deal with feeding.
- [`Staff.cs`](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/Staff.cs) - is responsible for storing information and functionality regarding zoo employees. 

    Each class has a clear responsibility.
## Open/Closed Principle
`The gist:` The code should be open for extension, but closed for modification.

You can add new entities to the program simply by creating classes and adding them in the [Zoo "manager"](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Services/Zoo.cs). 

You can also specifically add functionality through factory methods in [AnimalFactory](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Services/AnimalFactory.cs#L14-L17) and if you need to add some logic with existing animals, you just need to write in this place.
You can add new entities to the program simply by creating classes and adding them in the Zoo "manager"
You can also specifically add functionality through factory methods in AnimalFactory and if you need to add some logic, you just need to add it

The [IZooReport interface](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Services/IZooReport.cs#L9-L12) also perfectly extends the logic of the program with Zoo class.

The code can be extended without changing existing classes!

## Liskov Substitution Principle
`The gist:` Subclass objects must correctly replace parent class objects.

