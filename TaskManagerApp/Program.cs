using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp;

namespace TaskManagerApp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Task> taskList = new List<Task>();

            string[] options = new string[]
                {"1.List Task", "2.Add Task", "3.Delete Task", "4.Mark Task Complete", "5.Quit Task Manager"};
            string[] menu = new string[]
                {"Complete?", "Team Member", "Destription", "Due Date"};
            bool run = true;
            Console.WriteLine("Welcome to the Task Manager!");

            while (run = true)
            {
               
                DisplayOptions(options);
                Console.WriteLine(" ");

                Console.WriteLine(" ");
                Console.Write("What would you like to do?");
            string action = Console.ReadLine();


                int n;

                switch (action)

                {
                    case "1":
                        Console.WriteLine($"{menu[0],-15}{menu[3],-15}{menu[1],-15}{menu[2],-15} ");
                        foreach (Task task in taskList)
                        {
                            Console.WriteLine($"{task.Complete,-15}{task.DueDate.ToShortDateString(),-15}{task.Name,-15}{task.Description,-15}");

                            Console.WriteLine();

                        }

                        break;

                    case "2":
                       
                            taskList.Add(new Task());
                        taskList[taskList.Count - 1].GetTask();
                        Console.WriteLine(" ");
                        Console.WriteLine("Task Entered");

                        break;


                    case "3":
                        Console.WriteLine($"Which task would you like to remove? 1 - {taskList.Count}");
                        int index = int.Parse(Console.ReadLine());
                        taskList.Remove(taskList[index - 1]);


                        break;                                     //delete task
                    case "4":
                        Console.WriteLine($"Which task would you like to mark complete? 1 - {taskList.Count}");
                        int num = int.Parse(Console.ReadLine());
                        taskList[num - 1].Complete = true;
                       
                        break;
                    case "5":
                        Console.WriteLine("Are you sure you want to quit?");
                        string quit = Console.ReadLine();
                        if (quit.ToLower() == "y")
                        {
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            break;
                        }
                  

                    default:
                        Console.WriteLine("Entry not valid");
                        break;
                }
            }
        }

        private static void DisplayOptions(string[] options)
        {
            
            foreach (string option in options)
            {
                Console.Write("--");
                Console.WriteLine(option.PadLeft(8));
            }
        }
    }
}
