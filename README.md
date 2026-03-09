# C# Fundamentals Playground

A collection of **C# fundamentals, experiments, and beginner exercises** implemented inside a single `Program.cs` file.

This project is designed as a **learning playground** where different core C# concepts are explored through simple examples and console exercises.

---

# Table of Contents

* [Project Structure](#project-structure)
* [Namespaces and Imports](#namespaces-and-imports)
* [Program Entry Point](#program-entry-point)
* [Hello World](#hello-world)
* [Variables and Data Types](#variables-and-data-types)
* [Numeric Data Types](#numeric-data-types)
* [Text Data Types](#text-data-types)
* [Type Conversion](#type-conversion)
* [Console Input / Output](#console-input--output)
* [Conditional (Ternary) Operator](#conditional-ternary-operator)
* [Safe Conversion with TryParse](#safe-conversion-with-tryparse)
* [Exercise 1 – Variables](#exercise-1--variables)
* [Exercise 2 – Modulus Operator](#exercise-2--modulus-operator)
* [Exercise – Multiplication Table](#exercise--multiplication-table)
* [Exercise – FizzBuzz](#exercise--fizzbuzz)
* [Exercise – Reverse String](#exercise--reverse-string)
* [Exercise – Password Checker](#exercise--password-checker)
* [Arrays](#arrays)
* [Array Sorting](#array-sorting)
* [Keeping the Console Open](#keeping-the-console-open)

---

# Project Structure

```
MyFirstProject
│
├── Program.cs
└── README.md
```

`Program.cs` contains the **main entry point and all learning examples**.

---

# Namespaces and Imports

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
```

These namespaces provide built-in functionality:

| Namespace                    | Purpose                  |
| ---------------------------- | ------------------------ |
| `System`                     | Core functionality       |
| `System.Collections.Generic` | Generic collections      |
| `System.Linq`                | Querying collections     |
| `System.Net.Sockets`         | Networking utilities     |
| `System.Text`                | Text encoding            |
| `System.Threading.Tasks`     | Asynchronous programming |

---

# Namespace

```csharp
namespace MyFirstProject
```

Namespaces organize classes and prevent naming conflicts.

---

# Program Class

```csharp
internal class Program
```

`internal` means the class is accessible **only within the same assembly**.

---

# Program Entry Point

```csharp
static void Main(string[] args)
```

The **Main method is the starting point of every C# console application**.

---

# Hello World

```csharp
Console.WriteLine("Hello World!");
```

Prints text to the console.

---

# Variables and Data Types

Example:

```csharp
int age = 23;
Console.WriteLine(age);
```

| Component | Meaning       |
| --------- | ------------- |
| `int`     | Data type     |
| `age`     | Variable name |
| `23`      | Stored value  |

---

# Numeric Data Types

### Long

```csharp
long bigNumber = 23423423243L;
```

`L` tells the compiler the number is **Long**.

---

### Double

```csharp
double negative = -44.2D;
```

`D` indicates the number is a **double**.

---

### Float

```csharp
float precision = 5.000001F;
```

`F` indicates a **float literal**.

---

### Decimal

```csharp
decimal money = 14.99M;
```

`M` represents **decimal**, usually used for financial calculations.

---

# Text Data Types

```csharp
string name = "aba";
char letter = 'a';
```

| Type     | Description               |
| -------- | ------------------------- |
| `string` | Stores text               |
| `char`   | Stores a single character |

---

# Type Conversion

### String → Integer

```csharp
string textAge = "23";
int age = Convert.ToInt32(textAge);
```

### String → Long

```csharp
string textBigNumber = "90000000";
long bigNumber = Convert.ToInt64(textBigNumber);
```

### String → Double

```csharp
string textNegative = "-55.2";
double negative = Convert.ToDouble(textNegative);
```

---

# Console Input / Output

### Writing Output

```csharp
Console.WriteLine("Hello my name is Aryan");
```

### Reading Input

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();
```

### Reading Numeric Input

```csharp
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
```

### Printing Output

```csharp
Console.Write("Your name is ");
Console.Write(name);
Console.Write(" Your age is " + age);
```

---

# Conditional (Ternary) Operator

```csharp
string result = age >= 0 ? "Valid" : "Invalid";
Console.WriteLine(result);
```

Syntax:

```
condition ? value_if_true : value_if_false
```

---

# Safe Conversion with TryParse

```csharp
Console.WriteLine("Enter a number: ");
string numInput = Console.ReadLine();
int num = 0;

bool success = int.TryParse(numInput, out num);
Console.WriteLine(num);
```

`TryParse()` safely converts input without crashing.

---

# Exercise 1 – Variables

Task:

* Define variable for name
* Define variable for phone number
* Define variable for age
* Print them line by line
* Use `var` keyword

```csharp
var name = "Aryan";
var phone = 90909099;
var age = 19;

Console.WriteLine(name);
Console.WriteLine(phone);
Console.WriteLine(age);
```

---

# Exercise 2 – Modulus Operator

```csharp
int a = 10;
int b = 20;

int result = a % b;
Console.WriteLine(result);

a = 40;
Console.WriteLine(a % b);
```

`%` returns the remainder.

Example:

```
10 % 3 = 1
```

---

# Exercise – Multiplication Table

```csharp
Console.WriteLine("Write a number for the table: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
}
```

---

# Exercise – FizzBuzz

Rules:

* divisible by 3 → FIZZ
* divisible by 5 → BUZZ
* divisible by 3 and 5 → FIZZ BUZZ

```csharp
for(int i = 1; i <= number; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FIZZ BUZZ");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("FIZZ");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("BUZZ");
    }
    else
    {
        Console.WriteLine(i);
    }
}
```

---

# Exercise – Reverse String

```csharp
Console.WriteLine("Enter your message: ");
string message = Console.ReadLine();
```

Print normally:

```csharp
for(int i = 0; i < message.Length; i++)
{
    Console.Write(message[i]);
}
```

Print reversed:

```csharp
for(int i = message.Length - 1; i >= 0; i--)
{
    Console.Write(message[i]);
}
```

---

# Exercise – Password Checker

```csharp
Console.WriteLine("Please enter the password");
string password = Console.ReadLine();

Console.WriteLine("Please re-enter the password");
string confirmPassword = Console.ReadLine();
```

Validation:

```csharp
if(!password.Equals(string.Empty) && !confirmPassword.Equals(string.Empty))
{
    if(password.Equals(confirmPassword))
    {
        Console.WriteLine("Password match");
    }
    else
    {
        Console.WriteLine("Password do not match");
    }
}
else
{
    Console.WriteLine("Please enter the password");
}
```

---

# Arrays

Creating arrays:

```csharp
int[] numbers = new int[3];
int[] num = new int[3];
```

Assign values:

```csharp
numbers[0] = 5;
numbers[1] = 10;
numbers[2] = 15;
```

Taking input:

```csharp
Console.WriteLine("Enter 3 number: ");

num[0] = Convert.ToInt32(Console.ReadLine());
num[1] = Convert.ToInt32(Console.ReadLine());
num[2] = Convert.ToInt32(Console.ReadLine());
```

Printing values:

```csharp
Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
```

---

# Array Sorting

Example:

```csharp
Array.Sort(numbers);
```

Sorts the array in ascending order.

---

# Keeping the Console Open

```csharp
Console.ReadLine();
```

Prevents the application from closing immediately.

---

# Summary

This project demonstrates:

* Variables
* Data types
* Type conversion
* Console input/output
* Conditional logic
* Ternary operator
* TryParse
* Loops
* FizzBuzz logic
* String manipulation
* Password validation
* Arrays

---

# Author

**Aryan Mishra**

Learning **C#, .NET, and Full Stack Development**.
