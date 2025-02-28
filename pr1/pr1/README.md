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

Animal implements [IAnimal](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/IAnimal.cs), and all animals are used through IAnimal without any problems.
If we cast Animal to List<IAnimal>, nothing will break.

## Interface Segregation Principle
`The gist:` Don't force classes to implement methods they don't need.

I removed `IFeedable`, which was originally an idea, but it turned out to be redundant since all IAnimals eat anyway.
No unnecessary interfaces were created that don't make sense.
Each interface ([IZooReport](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Services/IZooReport.cs), [IAnimal](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/IAnimal.cs)) only has the necessary methods.

## Dependency Inversion Principle
`The gist:` Code should depend on abstractions rather than concrete classes.

And there great example with abstraction [IAnimal](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/IAnimal.cs) and simple class [Animal](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/Animal.cs). In the code I use interfaces for interactions and working with [methods](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/IAnimal.cs#L9-L17).

<hr>

## DRY (Don't repeat yourself)
`The gist:` Avoid code duplication.

- [AnimalFactory](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Services/AnimalFactory.cs#L12-L18) creates animals, so we don't write `new Animal(...)` in Program.cs manually.
- Also in special case we can consider [Zoo.GenerateReport()](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Services/Zoo.cs#L32-L65) for this principle. It doesn't duplicate code - all the data collection logic is moved to a separate method (in another way we need to write all small calls to object lists).
- And many different small but common functions are separate methods (for example, getters, setters, calculating salary).

## YAGNI (You Ain’t Gonna Need It)
`The gist:` Don't add code or functionality that "might be needed in the future" but isn't currently used.

- I removed the `IFeedable` interface because it's more universal and rational to do it through the [Feed()](https://github.com/ipsolver/KPZ/blob/lab-1/pr1/pr1/Models/IAnimal.cs#L16) method.
- I also had classes for classifying animals (Mammals, Birds, Insects) and through the factory I planned to work with instances of certain classes, although in this work it will already be a "superstructure" and may somewhat complicate both the initial design of the project and understanding in general.

- And I can say that my program is user-friendly and it's clear and clearly divided into general abstractions, which makes it more versatile and effective in the perspective of laboratory work and the zoo accounting system.

<hr>

## UML-diagram