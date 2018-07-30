using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TaskManagerApp
{
    public class Task
    {
        public string Name;
        public string Description;
        public DateTime DueDate;
        public bool Complete;
        public List<Task> _tasks;
        private bool _isValid;
        public List<DateTime> _DueDate;

        public Task()
        {

        }

        public bool GetComplete()
        {

            Complete = false;
            
            return false;
        }
        public void GetTask()
        {
           
            Console.WriteLine("Who is this task for?");
            Name = Console.ReadLine();
            Console.WriteLine("What is this task");
            Description = Console.ReadLine();
            Console.WriteLine("What is the Due Date (mm:dd:yyyy)");
            bool isValid = false;

            while (!isValid)
            {
                try
                {
                    DueDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.CurrentCulture);
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That time format is not valid, please try again.");

                }
            }



            Complete = false;
        }
    }
}