# csharp-examples
Some basic training tasks in C#.

The problem texts were prepared using DeppSeek.

## Block 1

Basic syntax, types, branches, loops

### Task 1

Write a console program that asks the user for their name and age and then displays the message:
`"Hello, {name}! In 5 years, you will be {age+5} years old."`
Use `Console.ReadLine()`, `int.Parse()`, or `TryParse()`.

### Task 2

Create a static int SumEvenNumbers(int[] numbers) method that takes an array of integers and returns the sum of the even elements.
In Main(), test it on the array {1,2,3,4,5,6} (should be 12). Use a foreach loop.

## Block 2

Classes, objects, properties, constructors

### Task 1

Create a `Player` class with fields:
- `private string name;`
- `private int health;`
- `private int score;`

Add:
- A constructor with parameters (`name`, `health`, `score`).
- `Read/write` properties (with validation: health cannot be below 0 or above 100; name cannot be empty).
- The `void TakeDamage(int damage)` method reduces health, but not below 0.
- The `void AddScore(int points)` method.
- The `void PrintInfo()` method displays the player's status.

Add a `static int totalPlayers` field to the Player class, which is incremented in the constructor. Add a `static void ShowTotalPlayers()` method. Test your work.

### Block 3

Inheritance, polimorphism, interfaces

### Task 1

Create a base class called `Enemy` with the properties `string Name`, `int Health`, and a `virtual method void TakeDamage(int damage)` that reduces health.

Create the following classes:

Goblin – when taking damage, it additionally displays `"Goblin squeals!"`

Troll – has an additional field called `int Regeneration` and an overridden method called `TakeDamage`: after taking damage, health is restored by the amount of Regeneration every second

Create a `List<Enemy>`, add different enemies, iterate through them, and call `TakeDamage(10)` on each – demonstrating polymorphism.