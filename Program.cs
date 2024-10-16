using System;
using System.Diagnostics;

// Runtime
main();

// Main module 

static void main()
{
    

    // Looping till exit
    while (true) {
        display();
    }
}

static string userInput()
{
    // Module to read userinput
    string userChoice = Console.ReadLine()
                               .ToUpper();
    switch (userChoice)
    {
        case "S":
            Console.WriteLine("[S]ee all TODOs");
            break;
        case "A":
            Console.WriteLine("[A]dd a TODO");
            break;
        case "R":
            Console.WriteLine("[R]emove a TODO");
            break;
        case "E":
            Console.WriteLine("[E]xit");
            break;
        default:
            Console.WriteLine("Nothing selected / Wrong input!");
            return "invalid";
    }

    Console.WriteLine("User input:" + userChoice);
    return userChoice; 
}

static void display()
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?\n");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    userInput();

    ;


    Console.ReadKey();

}

// See todo module

// Add todo module

// Remove todo module

// Exit module
