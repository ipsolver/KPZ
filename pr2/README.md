## Fabric Method
### Structure
1) [Abstract factory](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task1/SubscribtionFactory.cs)

It defines the method:
- CreateSubscribtion
2) [Abstract class](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task1/Subscribtion.cs)

It defines there properties:
- int cost
- int minimum
-  List<string> chanels
-  bool advertisement
- string Name

And method:
- void DoPayment()

3) Specific classes:
- [DomesticSubscription](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task1/DomesticSubscription.cs)
- [EducationalSubscription](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task1/EducationalSubscription.cs)
- [PremiumSubscription](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task1/PremiumSubscription.cs)

 - - These classes implement the abstract Subscription class.
   - They also have constructors with "built-in" values ​​according to the subscription.
   - Implement the `DoPayment()` method to output information
4) Specific factories:
- WebSite
- MobileApp
- ManagerCall

### Result
- The factory method is implemented through: `Abstract class SubscriptionFactory`, which defines the CreateSubscription() method.
- Concrete factories (WebSite, MobileApp, ManagerCall) that [override CreateSubscription()](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task1/MobileApp.cs#L11).


## Abstract Factory
### Structure
1) [Abstract factory](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Interfaces/IDeviceFactory.cs)

Defines such methods:
- CreateLaptop
- CreateNetbook
- CreateEBook
- CreateSmartphone

2) Interfaces:
- [IEBook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Interfaces/IEBook.cs)
- [ILaptop](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Interfaces/ILaptop.cs)
- [INetbook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Interfaces/INetbook.cs)
- [ISmartphone](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Interfaces/ISmartphone.cs)

These have properties:
- string Name { get; }
- float Price {  get; }

And method:
- void Info();

3) Specific factories:
- [KiaomiFactory](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Classes/KiaomiFactory.cs)
- [IProneFactory](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Classes/IProneFactory.cs)
- [BalaxyFactory](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Classes/BalaxyFactory.cs)

They accordingly determine the methods:
- ILaptop CreateLaptop()
- INetbook CreateNetbook()
- IEBook CreateEBook()
- ISmartphone CreateSmartphone()

Each factory implements IDeviceFactory and returns the corresponding products of its brand 

4) Products:
------------------
- [BalaxySmartphone](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/BalaxySmartphone.cs)
- [BalaxyNetbook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/BalaxyNetbook.cs)
- [BalaxyLaptop](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/BalaxyLaptop.cs)
- [BalaxyEBook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/BalaxyEBook.cs)
------------------
- [IProneSmartphone](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/IProneSmartphone.cs)
- [IProneNetbook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/IProneNetbook.cs)
- [IProneLaptop](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/IProneLaptop.cs)
- [IProneEBook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/IProneEBook.cs)
------------------
- [KiaomiSmartphone](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/KiaomiSmartphone.cs)
- [KiaomiNetbook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/KiaomiNetbook.cs)
- [KiaomiLaptop](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/KiaomiLaptop.cs)
- [KiaomiEBook](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task2/Products/KiaomiEBook.cs)

### Result

The Abstract Factory pattern allows for flexible control over the creation of objects, supports the "openness/closedness" principle, and simplifies the expansion of the project with new devices or brands.

For adding a new brand only you should create a new factory and corresponding product classes without changing existing code
<hr>

## Authenticator Singleton Pattern
### Class: Authenticator
The `Authenticator` class is designed to authenticate users while ensuring that only a single instance of it exists throughout the program's lifecycle.
### Implementation Details
#### Properties and Fields:
- [Stores the single instance of Authenticator](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task3/Authenticator.cs#L11).
- [Synchronization lock for thread safety](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task3/Authenticator.cs#L12)
- [Provides global access to the single instance, ensuring thread safety](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task3/Authenticator.cs#L14)
- [Ensuring protection against class inheritance with `sealed`](https://github.com/ipsolver/KPZ/blob/lab-2/pr2/pr2/Task3/Authenticator.cs#L9)
- Private static lockObject for thread synchronization
### What else?
- Private Constructor: Prevents external instantiation of the class
- Authenticate(): Demonstrates instance usage.
## Expected Output
```
Authenticating user1 with password my_password
Authenticating user2 with password your_password
Are user1 and user2 the same? True
```
The check was done with ReferenceEquals
<hr>

## UML-diagrams
### Abstract Factory
![Abstract_fabric.drawio (2).png](pr2/Diagrams/Abstract_fabric.drawio%20%282%29.png)
### Factory method
![fabric_method.drawio.png](pr2/Diagrams/fabric_method.drawio.png)
### Builder
![Builder.drawio.png](pr2/Diagrams/Builder.drawio.png)
