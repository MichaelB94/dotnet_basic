using System;
using System.Collections;
using System.Collections.Generic;

//ES. 1
Console.WriteLine("Welcome! Please enter 10 values:");

List<string> userInputList = new List<string>();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Enter value {i + 1}: ");
    string input = Console.ReadLine();
    userInputList.Add(input);
}

Console.WriteLine("Values entered:");
PrintList(userInputList);

Console.WriteLine("Values entered in reverse: ");
PrintListReversed(userInputList);
Console.WriteLine("Press any key to close the program");
Console.ReadKey();


static void PrintList(List<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

static void PrintListReversed(List<string> list)
{
    for (int i = list.Count - 1; i >= 0; i--)
    {
        Console.WriteLine(list[i]);
    }
}

//ES. 2
ArrayList myArrayList = new ArrayList();

myArrayList.Add(42);
myArrayList.Add("Hello, ArrayList!");
myArrayList.Add(true);

Console.WriteLine("Contents of ArrayList:");

foreach (var item in myArrayList)
{
    Console.WriteLine(item);
}

Console.WriteLine("Press any key to close the program");
Console.ReadKey();

//ES. 3

Queue<string> myqueue = new Queue<string>();
void EnqueueItem()
{
    Console.Write("Enter a string to enqueue: ");
    string item = Console.ReadLine();
    myqueue.Enqueue(item);
    Console.WriteLine($"\"{item}\" has been enqueued.");
}

void DequeueItem()
{
    if (myqueue.Count > 0)
    {
        string dequeuedItem = (string)myqueue.Dequeue();
        Console.WriteLine($"Dequeued item: {dequeuedItem}");
    }
    else
    {
        Console.WriteLine("Queue is empty. No items to dequeue.");
    }
}

void PeekItem()
{
    if (myqueue.Count > 0)
    {
        string peekedItem = (string)myqueue.Peek();
        Console.WriteLine($"Peeked item: {peekedItem}");
    }
    else
    {
        Console.WriteLine("Queue is empty. No items to peek.");
    }
}

while (true)
{
    Console.WriteLine("Queue Operations:");
    Console.WriteLine("1. Enqueue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. Peek");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        switch (choice)
        {
            case 1:
                EnqueueItem();
                break;

            case 2:
                DequeueItem();
                break;

            case 3:
                PeekItem();
                break;

            case 4:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.WriteLine();
}



    
