using System;
using System.Diagnostics;
using System.Collections.Generic;

class Todo
{
    // Initial memory/variables
    List<string> Todos = new List<string>() {"Test","Test2" };

    // Main module 
    static void Main(string[] args)
    {
        // creating new Todo object
        Todo t = new Todo();

        // Looping till exit
        while (true)
        {
            t.Display();
        }
    }

 

    string UserInput()
    {
        // Module to read userinput
        Console.WriteLine("Please write:");
        string userChoice = Console.ReadLine()
                                   .ToUpper();
        return userChoice;
    }

    public void Display()
    {
        // Initial greeting
        Console.WriteLine("Hello!");
        Console.WriteLine("What do you want to do?\n");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");

        // Todo Options
        switch (UserInput())
        {
            case "S":
                Console.WriteLine("[S]ee all TODOs");
                ViewTodo();
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
                break;
        }

    }

    // View todo module
    void ViewTodo()
    {

        while (true)
        {
            int y = 1;
            foreach (string i in Todos)
            {
                Console.WriteLine($"{y}. {i}");
                y++;
            }

            Console.WriteLine("Would you like to add more ? (Y/N)");
            string moduleChange = Console.ReadLine()
                                         .ToUpper();
            if (moduleChange == "Y") 
            {
                EditTodo();
            }
            else
            {
                return;
            }

        }

    }
    // Add todo module

    // Remove todo module

    // Exit module

}
