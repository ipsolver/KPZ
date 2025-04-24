### Лабораторна робота 4 з КПЗ
### Ланцюжок відповідальностей
#### Структура проекту
1) [`SupportHandler`](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/pr4_1/pr4_1/Task1/SupportHandler.cs) — абстрактний базовий клас. Він містить метод [SetNext(SupportHandler handler)](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/pr4_1/pr4_1/Task1/SupportHandler.cs#L13) для побудови ланцюга, а також метод [Handle(string message)](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/pr4_1/pr4_1/Task1/SupportHandler.cs#L19), який або обробляє запит, або передає далі
2) Конкретні обробники:
- [AdminSupport](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/pr4_1/pr4_1/Task1/AdminSupport.cs) - обробляє адміністративні запити
- [TechnicalSupport](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/pr4_1/pr4_1/Task1/TechnicalSupport.cs) - відповідає на технічні питання
- [TariffSupport](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/pr4_1/pr4_1/Task1/TariffSupport.cs) - працює з питаннями тарифів
- [MainSupport](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/pr4_1/pr4_1/Task1/MainSupport.cs) - перший у ланцюгу, відповідає за загальний запит

Це рішення демонструє застосування патерна "Ланцюжок відповідальностей", де кожен обробник виконує свою частину роботи або передає запит далі по ланцюгу. Це дозволяє гнучко масштабувати систему, додаючи нові типи підтримки без зміни існуючих класів.

### Посередник
#### Структура проекту
1) [IAirTrafficMediator](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/Mediator/Mediator/IAirTrafficMediator.cs) — інтерфейс, який визначає методи для взаємодії між компонентами
2) [CommandCentre](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/Mediator/Mediator/CommandCentre.cs) — конкретна реалізація IAirTrafficMediator. Управляє взаємодією між об'єктами Aircraft та Runway. Знає, які смуги зайняті та які літаки чекають на посадку
3) [Component](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/Mediator/Mediator/Component.cs) - базовий клас для учасників системи. Містить посилання на медіатор та метод SetMediator
4) [Aircraft](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/Mediator/Mediator/Aircraft.cs) — учасник, що ініціює запит на посадку (RequestLanding) через медіатор
5) [Runway](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/Mediator/Mediator/Runway.cs) — учасник, що може бути зайнятим або вільним, повідомляє медіатора про зміни статусу

У цьому завданні реалізовано поведінковий патерн "Посередник", який дозволяє компонентам (літакам і злітним смугам) взаємодіяти через централізований об'єкт (CommandCentre), не залежачи один від одного безпосередньо. Такий підхід спрощує архітектуру, зменшуючи кількість зв'язків між об'єктами, і робить систему легшою для модифікації.

### [Спостерігач](https://github.com/ipsolver/KPZ/pull/1)
#### Структура проекту
1) Інтерфейс [IEventListener](https://github.com/ipsolver/KPZ/blob/lab4_PR3/pr3/pr3/Task5/Interfaces/IEventListener.cs) для спостерігачів
2) Розширено клас [LightElementNode](https://github.com/ipsolver/KPZ/blob/lab4_PR3/pr3/pr3/Task5/Classes/LightElementNode.cs)
- Додано поле:
- - private Dictionary<string, List<IEventListener>> _eventListeners;
- Методи:
- - AddEventListener(string eventType, IEventListener listener) — підписка на подію
- - Click() і MouseOver() — штучний виклик відповідних подій
- - Notify(string eventType) — повідомлення для підписаних спостерігачів
3) Додано спостерігач [Loger](https://github.com/ipsolver/KPZ/blob/lab4_PR3/pr3/pr3/Task5/Classes/Loger.cs) який реалізує інтерфейс IEventListener та виводить логи про виконання тих чи інших EventListeners

### [Стратегія](https://github.com/ipsolver/KPZ/pull/2)
#### Структура проекту

1) Додано новий клас [LightImageNode](https://github.com/ipsolver/KPZ/blob/lab4_PR4/pr3/pr3/Task5/Classes/LightImageNode.cs), який є підтипом LightNode і відповідає за рендер HTML-елемента <img>
2) Реалізовано інтерфейс [ILoadStrategy](https://github.com/ipsolver/KPZ/blob/lab4_PR4/pr3/pr3/Task5/Interfaces/ILoadStrategy.cs) — власне інтерфейс для завантаження зображення
3) Додано дві конкретні стратегії:
- [FileLoadStrategy](https://github.com/ipsolver/KPZ/blob/lab4_PR4/pr3/pr3/Task5/Classes/FileLoadStrategy.cs) — завантаження зображення з файлової системи
- [NetworkLoadStrategy](https://github.com/ipsolver/KPZ/blob/lab4_PR4/pr3/pr3/Task5/Classes/NetworkLoadStrategy.cs)  - завантаження з мережі
4) Вибір стратегії відбувається всередині LightImageNode автоматично, залежно від href

### Мементо
### Структура проекту

1) [TextDocument](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/Memento/Memento/TextDocument.cs) — основний об'єкт (Originator), який містить текст. Має методи:
- Save() — створює знімок (Memento) поточного стану
- Restore(DocumentMemento memento) — відновлює стан із знімка
2) [TextEditor](https://github.com/ipsolver/KPZ/blob/lab-4/pr4/Memento/Memento/TextEditor.cs) — клас-наглядач (Caretaker), який керує історією збережених станів. Містить стек історії, що дозволяє повертатися назад (undo):
- Write(string text) — змінює текст і зберігає попередній стан
- Undo() — відновлює попередній збережений стан
