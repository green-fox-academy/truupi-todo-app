using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static TaskList tasking = new TaskList();

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ArgumentsList();
            }
            else if (args.Contains("-l"))
            {
                tasking.ListTasks();
            }
            else if (args.Contains("-a"))
            {
                    tasking.AddTask(args);
            }
            else if (args.Contains("-r"))
            {
                tasking.RemoveTask(args[1]);
            }
            else if (args.Contains("-f"))
            {
                tasking.CheckTask();
            }
            else
            {
                Console.WriteLine("Unsupported argument!");
            }
            Console.ReadLine();
        }

        static void ArgumentsList()
        {
            string path = @"..\..\assets\welcomemsg.txt";
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
