using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;
using System.IO;
using Exercises;

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

Console.WriteLine("Welcome to Reverso.");
Console.WriteLine("Please write some text, i'll reverse it for you!");

static string ReverseString(string textInput)
{
    char[] charArray = textInput.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

string? reversedText = ReverseString(Console.ReadLine());
Console.WriteLine($"txet desrever : {reversedText}");

Console.WriteLine("press any button to close the program");
Console.ReadKey();

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

Console.WriteLine("Welcome to AnimalSound");

Dog myDog = new Dog("Loki", 3);
Cat myCat = new Cat("Thor", 2);
Horse myHorse = new Horse("Hulk", 5);

myDog.Speak();
myCat.Speak();
myHorse.Speak();


Console.WriteLine("Press any key to close the program");
Console.ReadKey();


