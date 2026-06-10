# C# Basics Learning Repository 🚀

## 📖 Overview

This repository contains the fundamental concepts of C# programming language. It is designed for beginners who want to learn C# from scratch and build a strong foundation for .NET development, desktop applications, web applications, and software engineering interviews.

---

# 📚 Topics Covered

## 1. Introduction to C#

* What is C#?
* Features of C#
* History of C#
* .NET Framework vs .NET Core vs .NET

---

## 2. C# Program Structure

* Namespace
* Class
* Main Method
* Comments

Example:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
    }
}
```

---

## 3. Variables

* Local Variables
* Global Variables
* Constants

Example:

```csharp
int age = 25;
string name = "John";
const double PI = 3.14;
```

---

## 4. Data Types

### Value Types

* int
* float
* double
* decimal
* char
* bool

### Reference Types

* string
* object
* arrays
* classes

---

## 5. Operators

### Arithmetic Operators

* *
* *
* *
* /
* %

### Comparison Operators

* ==
* !=
* >
* <
* > =
* <=

### Logical Operators

* &&
* ||
* !

---

## 6. Input and Output

```csharp
Console.Write("Enter Name: ");
string name = Console.ReadLine();

Console.WriteLine($"Welcome {name}");
```

---

## 7. Conditional Statements

### if Statement

```csharp
if(age >= 18)
{
    Console.WriteLine("Eligible");
}
```

### if-else

### else-if Ladder

### switch Statement

---

## 8. Loops

### for Loop

```csharp
for(int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

### while Loop

### do-while Loop

### foreach Loop

---

## 9. Arrays

### Single Dimensional Array

```csharp
int[] numbers = {10,20,30,40};
```

### Multi-Dimensional Array

### Jagged Array

---

## 10. Strings

* String Methods
* String Concatenation
* String Interpolation
* StringBuilder

Example:

```csharp
string name = "Mohit";
Console.WriteLine(name.ToUpper());
```

---

## 11. Methods

### Void Method

### Return Type Method

### Method Parameters

### Optional Parameters

Example:

```csharp
static int Add(int a, int b)
{
    return a + b;
}
```

---

## 12. Exception Handling

* try
* catch
* finally
* throw

Example:

```csharp
try
{
    int result = 10 / 0;
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

---

## 13. Object-Oriented Programming (OOP)

### Classes and Objects

### Constructor

### Inheritance

### Polymorphism

### Encapsulation

### Abstraction

---

## 14. Access Modifiers

* public
* private
* protected
* internal

---

## 15. Properties

```csharp
public string Name { get; set; }
```

---

## 16. Collections

### List

```csharp
List<string> names = new List<string>();
```

### Dictionary

### HashSet

### Queue

### Stack

---

## 17. LINQ Basics

* Where()
* Select()
* OrderBy()
* FirstOrDefault()

Example:

```csharp
var result = numbers.Where(n => n > 10);
```

---

## 18. File Handling

* Read File
* Write File
* Append File

Example:

```csharp
File.WriteAllText("test.txt", "Hello");
```

---

## 19. Common Coding Programs

### Prime Number

### Palindrome Number

### Armstrong Number

### Fibonacci Series

### Factorial

### Reverse Number

### Reverse String

### Largest Number in Array

### Second Largest Number

### Bubble Sort

### Duplicate Elements

### Count Vowels

---

## 20. C# Interview Questions

### Theory

* Value Type vs Reference Type
* Class vs Object
* Abstract Class vs Interface
* Method Overloading vs Overriding
* Ref vs Out vs In
* String vs StringBuilder
* IEnumerable vs IQueryable
* Boxing vs Unboxing

### Coding

* Prime Number
* Fibonacci Series
* Palindrome
* Factorial
* Array Sorting
* LINQ Queries

---

## 🛠 Technologies Used

* C#
* .NET
* Visual Studio
* Console Applications

---

## 🚀 Getting Started

### Clone Repository

```bash
git clone https://github.com/your-username/csharp-basics.git
```

### Open Project

```bash
cd csharp-basics
```

### Run Project

```bash
dotnet run
```

---

## 🎯 Learning Path

1. C# Basics
2. Variables & Data Types
3. Operators
4. Conditions & Loops
5. Arrays & Strings
6. Methods
7. Exception Handling
8. OOP Concepts
9. Collections
10. LINQ
11. File Handling
12. Coding Problems
13. Interview Preparation

---

## 📈 Repository Goal

The goal of this repository is to help beginners learn C# fundamentals, practice coding problems, understand OOP concepts, and prepare for .NET developer interviews.

---

## 👨‍💻 Author

Created for learning C#, .NET development, coding practice, and interview preparation.
