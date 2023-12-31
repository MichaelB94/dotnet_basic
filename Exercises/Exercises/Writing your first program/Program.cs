﻿using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;
using System.IO;
using Exercises;

//ES. 1
Console.WriteLine("What's your name?");

string? name = Console.ReadLine();

if (name == null)
{
    Console.WriteLine("Name not valid.");
}
else
{
    Console.WriteLine("Hello, " + name);
}


//Es. 2
Console.WriteLine("Welcome to AddCalculator.");
Console.Write("Enter the first number: ");
String firstInput = Console.ReadLine();

if (!double.TryParse(firstInput, out double firstNumber))
{
    Console.WriteLine("Invalid input for the first number.");
    return;
}

Console.Write("Enter the second number: ");
string secondInput = Console.ReadLine();

if (!double.TryParse(secondInput, out double secondNumber))
{
    Console.WriteLine("Invalid input for the second number.");
    Console.ReadKey();
    return;
}

double sum = firstNumber + secondNumber;
Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
//Es. 3
Console.WriteLine("Welcome to Reverso.");
Console.WriteLine("Please write some text, i'll reverse it for you!");

static string ReverseString(string textInput)
{
    char[] output = textInput.ToCharArray();
    Array.Reverse(output);
    return new string(output);
}

string? reversedText = ReverseString(Console.ReadLine());
Console.WriteLine($"txet desrever : {reversedText}");

Console.WriteLine("press any button to close the program");
Console.ReadKey();
// Es 5
Console.WriteLine("Welcome to FileReader");
Console.WriteLine("Enter the file path:");
string filePath = Console.ReadLine();

 try
 {
    string fileContent = ReadFile(filePath);
    Console.WriteLine("File Content:");
    Console.WriteLine(fileContent);
 }
 catch (Exception ex)
 {
    Console.WriteLine($"An error occurred: {ex.Message}");
 }
static string ReadFile(string path)
{
    if (!File.Exists(path))
    {
        throw new FileNotFoundException($"File not found: {path}");
    }

    string fileContent = File.ReadAllText(path);
    return fileContent;
}

Console.WriteLine("Press any key to close the program");
Console.ReadKey();

//ES 6
Console.WriteLine("Welcome to AnimalSound");

Dog myDog = new Dog("Loki", 3);
Cat myCat = new Cat("Thor", 2);
Horse myHorse = new Horse("Hulk", 5);

myDog.Speak();
myCat.Speak();
myHorse.Speak();


Console.WriteLine("Press any key to close the program");
Console.ReadKey();

//ES 8
Console.WriteLine("Welcome to PalindromeCheck");
Console.WriteLine("Enter the sentence you want to check:");
string? sentence = Console.ReadLine();

static bool IsPalindrome(string? text) 
{
    if(text == null) 
    {
        return false;
    }
    string input = text.Replace(" ", "").ToLower();
    string reversedText = ReverseString(input);
    return input == reversedText;
}

bool isPalindrome = IsPalindrome(sentence);

if (isPalindrome)
{
    Console.WriteLine($"{sentence} is a palindrome.");
}
else
{
    Console.WriteLine($"{sentence} is not a palindrome.");
}

Console.WriteLine("Press any key to close the program");
Console.ReadKey();

//ES 9

Console.WriteLine("Welcome to Celsius2Fahrenheit");


static void ConvertCelsiusToFahrenheit()
{
    Console.Write("Enter temperature in Celsius: ");
    if (double.TryParse(Console.ReadLine(), out double celsius))
    {
        double fahrenheit = celsius * 1.8 + 32;
        Console.WriteLine($"{celsius}°C in Fahrenheit: {fahrenheit}°F");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid numeric value for temperature.");
    }
}
ConvertCelsiusToFahrenheit();
Console.WriteLine("Press any key to close the program");
Console.ReadKey();

//ES 9

Console.WriteLine("Temperature Converter");

Console.WriteLine("Choose conversion:");
Console.WriteLine("1. Celsius to Fahrenheit");
Console.WriteLine("2. Fahrenheit to Celsius");

static void ConvertFahrenheitToCelsius()
{
    Console.Write("Enter temperature in Fahrenheit: ");
    if (double.TryParse(Console.ReadLine(), out double fahrenheit))
    {
        double celsius = (fahrenheit - 32) * 0.5556;
        Console.WriteLine($"{fahrenheit}°F in Celsius: {celsius}°C");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid numeric value for temperature.");
    }
}

if (int.TryParse(Console.ReadLine(), out int choice))
{
    switch (choice)
    {
        case 1:
            ConvertCelsiusToFahrenheit();
            break;

        case 2:
            ConvertFahrenheitToCelsius();
            break;

        default:
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            break;
        }
    }
else
{
    Console.WriteLine("Invalid input. Please enter a valid numeric choice.");
}

Console.WriteLine("Press any key to close the program");
Console.ReadKey();

// Create a class with private, protected, internal, and public access modifiers.
// In a separate class, try accessing these members and observe the compilation errors,
// if any. Fix the errors by modifying the access modifiers or using proper access techniques.

Try NewClass = new Try()
{
    Address = "Via",
    Age = 29
};

NewClass.SetProtectedID(1);
string? n = Console.ReadLine();
if (n == null)
{
    throw new InvalidOperationException();
}

NewClass.SetPrivateString(n);



