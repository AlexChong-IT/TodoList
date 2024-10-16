using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

class Todo
{
    // Initial memory/variables
    bool running = true;
    List<string> Todos = new List<string>() {"Test","Test2" };

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
                ExitTodo();
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

            return;

            //Console.WriteLine("Would you like to add a todo ? (Y/N)");
            //string moduleChange = Console.ReadLine()
            //                             .ToUpper();
            //if (moduleChange == "Y") 
            //{
            //    AddTodo();
            //}
            //else
            //{
            //    return;
            //}

        }

    }
    // Add todo module
    void AddTodo()
    {
        while(true)
        {

        }
    }
    // Remove todo module
    void RemoveTodo()
    {

    }

    // Exit module
    void ExitTodo()
    {
        Console.WriteLine("Exiting Program now!");
        Thread.Sleep(2000);
        running = false;
    }
}
