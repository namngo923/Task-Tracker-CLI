using System;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskService = new TaskService();
            bool exit = false;

            Console.WriteLine("Welcome to Task Manager!");
            Console.WriteLine("Commands: add, list, complete, remove, exit");

            while (!exit)
            {
                Console.Write("\n> ");
                var input = Console.ReadLine()?.Trim().Split(' ', 2);
                if (input == null || input.Length == 0) continue;

                var command = input[0].ToLower();
                var argument = input.Length > 1 ? input[1] : string.Empty;

                switch (command)
                {
                    case "add":
                        TaskItemAdd taskAdd =new TaskItemAdd();
                        Console.Write("Title: "); taskAdd.Title = Console.ReadLine(); Console.Write("\n");
                        if (input == null || input.Length == 0)
                        {
                            Console.WriteLine("Please provide a task Title.");
                            break;
                        }
                        Console.Write("Description: "); taskAdd.Description = Console.ReadLine(); Console.Write("\n");
                        Console.Write("Assigner: "); taskAdd.Assigner = Console.ReadLine(); Console.Write("\n");
                        if (taskAdd.Assigner == null || taskAdd.Assigner.Length == 0)
                        {
                            Console.WriteLine("Please provide a task Assigner.");
                            break;
                        }

                        if (!string.IsNullOrWhiteSpace(taskAdd.Title))
                        {
                            taskService.AddTask(taskAdd);
                            Console.WriteLine($"Task added: {taskAdd.Title}");
                        }
                        else
                        {
                            Console.WriteLine("Please provide a task description.");
                        }
                        break;

                    case "list":
                        var tasks = taskService.GetTasks();
                        if (!tasks.Any())
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            foreach (var task in tasks)
                            {
                                Console.WriteLine(task);
                            }
                        }
                        break;

                    case "detail":
                        if (int.TryParse(argument, out var taskId))
                        {
                            Console.Write(taskService.GetTaskDetail(taskId));                       
                        }
                        else
                        {
                            Console.WriteLine("Please provide a valid task ID.");
                        }
                        break;

                    case "update":
                        if (int.TryParse(argument, out var taskUpdateId))
                        {
                            taskService.UpdateTask(taskUpdateId);
                        }
                        else
                        {
                            Console.WriteLine("Please provide a valid task ID.");
                        }
                        break;
                    case "remove":
                        if (int.TryParse(argument, out var removeId))
                        {
                            if (taskService.RemoveTask(removeId))
                            {
                                Console.WriteLine($"Task {removeId} removed.");
                            }
                            else
                            {
                                Console.WriteLine($"Task {removeId} not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please provide a valid task ID.");
                        }
                        break;

                    case "exit":
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    case "cls":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Unknown command. Please try again.");
                        break;
                }
            }
        }
    }
}
