## Structural patterns
<hr>

### Task 1 Adapter

### Structure:

1) Interface:

- [ILogger](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task1/Interfaces/ILogger.cs): has methods
- - Log()
- - Error()
- - Warn()

2) Classes:
- [Logger](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task1/Classes/Logger.cs): implements the ILogger interface, outputs messages to the console in different colors.
- [FileWriter](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task1/Classes/FileWriter.cs): implements writing to a file
- [FileLoggerAdapter](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task1/Classes/FileLoggerAdapter.cs): adapter for using FileWriter as a logger

<hr>

### Task 2 Decorator

### Structure:

1) Interface
- [ICharacter](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Interfaces/ICharacter.cs) has methods:
- - string Info() - method that shows information about hero
  - int GetPower() - method that gets the count of hero's power
2) Classes of hero
- [Mage](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/Mage.cs)
- [Paladin](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/Paladin.cs)
- [Warrior](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/Warrior.cs)
They implement ICharacter
3) Classes of inventory
- [Amulet](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/Amulet.cs)
- [Baculus](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/Baculus.cs)
- [Glove](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/Glove.cs)
- [Sword](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/Sword.cs)
They implement the decorator by changing methods and modifying the hero class
4) Decorator
- [InventoryDecorator](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task2/Classes/InventoryDecorator.cs)

Сreates special "wrappers" for heroes

<hr>

### Task 3 Bridge

### Structure

1) Interface
- [IRender](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task3/Interfaces/IRender.cs)
  
It has method:
  
- Render() - method for rendering shapes in various formats
2) Abstract cLass
- [Shape](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task3/Classes/Shape.cs) - an abstract class that has an abstract Draw method.
An object of type IRender is passed into the class constructor, which allows different shapes to be rendered in different ways

3) Shape classes
- [Circle](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task3/Classes/Circle.cs)
- [Square](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task3/Classes/Square.cs)
- [Triangle](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task3/Classes/Triangle.cs)

4) Rendering implementation
- [RasterRender](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task3/Classes/RasterRender.cs) - renders shapes as pixels
- [VectorRender](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task3/Classes/VectorRender.cs) - renders shapes as vectors

<hr>

### Task 4 Proxy

### Structure

1) Interface:
- [ITextReader](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task4/Interfaces/ITextReader.cs)
Defines the [Reading](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task4/Interfaces/ITextReader.cs#L11) method, which is used to read the contents of text files and convert them into a two-dimensional array

2) Class
- [SmartTextReader](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task4/Classes/SmartTextReader.cs)
It's directly responsible for reading files
3) Proxies
- [SmartTextChecker](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task4/Classes/SmartTextChecker.cs)
Adds additional behavior to the SmartTextReader class - logging
- [SmartTextReaderLocker](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task4/Classes/SmartTextReaderLocker.cs)
Restricts access to specific files using regular expressions

<hr>

### Task 5 Composer

### Structure

1) CLasses
- [LightNode](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task5/Classes/LightNode.cs) (Basic class)
An abstract class that defines the basic behavior for nodes in LightHTML
- [LightTextNode](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task5/Classes/LightTextNode.cs)
Represents a text node that contains only text and cannot have child elements (like leaf)
- [LightElementNode](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task5/Classes/LightElementNode.cs)
Can contain other nodes (LightNode), and also has attributes that define its behavior

<hr>

### Task 6 Flyweight

### Structure

1) Classes
- [LightNode](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task6/Classes/LightNode.cs)
Base class for all LightHTML nodes
- [LightTextNode ](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task6/Classes/LightTextNode.cs)
Represents a text node with no children
- [LightElementNode ](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task6/Classes/LightElementNode.cs)
Represents HTML elements that can contain text or other elements
- [LightElementFactory ](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task6/Classes/LightElementFactory.cs)
Caches HTML tag property objects to save memory
- [LightElementProperties ](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task6/Classes/LightElementProperties.cs)
Preserves the properties of HTML tags
- [LightHTMLMaster](https://github.com/ipsolver/KPZ/blob/lab-3/pr3/pr3/Task6/Classes/LightHTMLMaster.cs)
Manages the configuration of object creation
