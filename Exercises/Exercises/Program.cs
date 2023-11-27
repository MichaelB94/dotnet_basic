using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;
using System.IO;

//Console.WriteLine("What's your name?");

//string? name = Console.ReadLine();

//if (name == null)
//{
//    Console.WriteLine("Name not valid.");
//}
//else
//{
//    Console.WriteLine("Hello, " + name);
//}

//Console.WriteLine("Welcome to AddCalculator.");
//Console.Write("Enter the first number: ");
//String firstInput = Console.ReadLine();

//if (!double.TryParse(firstInput, out double firstNumber))
//{
//    Console.WriteLine("Invalid input for the first number.");
//    return;
//}

//Console.Write("Enter the second number: ");
//string secondInput = Console.ReadLine();

//if (!double.TryParse(secondInput, out double secondNumber))
//{
//    Console.WriteLine("Invalid input for the second number.");
//    Console.ReadKey();
//    return;
//}

//double sum = firstNumber + secondNumber;
//Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");

//Console.WriteLine("Welcome to Reverso.");
//Console.WriteLine("Please write some text, i'll reverse it for you!");

//static string ReverseString(string textInput)
//{
//    char[] charArray = textInput.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

//string? reversedText = ReverseString(Console.ReadLine());
//Console.WriteLine($"txet desrever : {reversedText}");

//Console.WriteLine("press any button to close the program");
//Console.ReadKey();

//Create a program, prompt the user for a file path. Then the program should read that file and print out
//the contents of that file. What happens when you point it to a text file? What happens when you point it
//to the PowerPoint file for this unit? Bonus points: make it work for both absolute and relative paths.


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

Console.WriteLine("Press any key to close the program");
Console.ReadKey();

static string ReadFile(string path)
{
    string fullPath = Path.Combine(Environment.CurrentDirectory, path);

    if (!File.Exists(fullPath))
    {
        throw new FileNotFoundException($"File not found: {fullPath}");
    }

    string fileContent = File.ReadAllText(fullPath);
    return fileContent;
}