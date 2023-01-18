using System;
using System.Collections.Generic;

class TodoList
{
    private List<string> tasks;

    public TodoList()
    {
        tasks = new List<string>();
    }

    public void AddTask(string task)
    {
        tasks.Add(task);
    }

    public void EditTask(int index, string newTask)
    {
        tasks[index] = newTask;
    }

    public void RemoveTask(int index)
    {
        tasks.RemoveAt(index);
    }

    public void DisplayTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine((i + 1) + ": " + tasks[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();

        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Edit Task");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Display Tasks");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter task: ");
                string task = Console.ReadLine();
                todoList.AddTask(task);
            }
            else if (choice == 2)
            {
                Console.Write("Enter task number: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Enter new task: ");
                string newTask = Console.ReadLine();
                todoList.EditTask(index - 1, newTask);
            }
            else if (choice == 3)
            {
                Console.Write("Enter task number: ");
                int index = int.Parse(Console.ReadLine());
                todoList.RemoveTask(index - 1);
            }
            else if (choice == 4)
            {
                todoList.DisplayTasks();
            }
            else
            {
                break;
            }
        }
    }
}
