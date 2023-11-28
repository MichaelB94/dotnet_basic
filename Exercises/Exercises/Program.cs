using System.Collections.Generic;
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
Console.Write("Enter temperature in Celsius: ");

static double ConvertCelsiusToFahrenheit(double celsius)
{
    return celsius * 1.8 + 32;
}
if (double.TryParse(Console.ReadLine(), out double celsius))
{
    double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
    Console.WriteLine($"{celsius}°C in Fahrenheit: {fahrenheit}°F");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid numeric value for temperature.");
}

Console.WriteLine("Press any key to close the program");
Console.ReadKey();



