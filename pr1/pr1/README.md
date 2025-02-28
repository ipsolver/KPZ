# SOLID principles
<hr>

## Single Responsibility Principle
`The gist:` Each class has a single responsibility.

- `Animal.cs` – is only responsible for storing data about the animal and its behavior.
- `Zoo.cs` – is only responsible for managing the zoo.
- `Enclosure.cs` – is only responsible for managing the enclosures.
- `Food.cs` – stores information about food, but does not deal with feeding.
- `Staff.cs` - is responsible for storing information and functionality regarding zoo employees. 

    Each class has a clear responsibility.
## Open/Closed Principle
`The gist:` The code should be open for extension, but closed for modification.

The code can be extended without changing existing classes!
