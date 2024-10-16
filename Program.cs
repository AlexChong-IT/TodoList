using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

class Todo
{
    // Initial memory/variables
    bool running = true;
    List<string> Todos = new List<string>() {"Test1" ,"Test2" };



    // Main module 
    static void Main(string[] args)
    {
        // creating new Todo object
        Todo t = new Todo();

        // Looping till exit
        while (t.running)
        {
            t.Display();
        }
    }

 

    string UserInput()
    {
        // Module to read userinput
        string userChoice;
        do
        {
            Console.WriteLine("Enter something:");
            userChoice = Console.ReadLine()
                .ToUpper();
            Thread.Sleep(1000);
        } while (string.IsNullOrWhiteSpace(userChoice));


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
                Console.WriteLine("\n[S]ee all TODOs");
                ViewTodo();
                break;
            case "A":
                Console.WriteLine("\n[A]dd a TODO");
                AddTodo();
                break;
            case "R":
                Console.WriteLine("\n[R]emove a TODO");
                RemoveTodo();
                break;
            case "E":
                Console.WriteLine("\n[E]xit");
                ExitTodo();
                break;
            default:
                Console.WriteLine("\nNothing selected / Wrong input!\n");
                Thread.Sleep(1000);
                System.Console.Clear();
                break;
        }

    }

    // View todo module
    void ViewTodo()
    {
        Console.WriteLine("\n~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Current ToDos");
        while (true)
        {
            if(Todos.Count == 0)
            {
                Console.WriteLine("No Todo has been added yet!");
            }


            int y = 1;
            foreach (string i in Todos)
            {
                Console.WriteLine($"{y}. {i}");
                y++;
            }

            Console.WriteLine("\n~~~~~~~~~~~~~~~~\n");
            Thread.Sleep(2000);
            return;

        }

    }
    // Add todo module
    void AddTodo()
    {
        string userInput = UserInput();
    
        if (!Todos.Contains(userInput))
        {
            Todos.Add(userInput);
            Console.WriteLine("\n~~~~~~~~~~~~~~~~\n");
            return;
        }
        else
        {
            Console.WriteLine("\nDescription already exist, returning to the main menu");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~\n");
            Thread.Sleep(1000);
            return;
        }


    }
    // Remove todo module
    void RemoveTodo()
    {
        Todos.Remove(UserInput());
    }

    // Exit module
    void ExitTodo()
    {
        Console.WriteLine("Exiting Program now!");
        Thread.Sleep(2000);
        running = false;
    }
}
