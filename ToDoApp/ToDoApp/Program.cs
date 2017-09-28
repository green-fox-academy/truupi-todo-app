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
        static void Main(string[] args)
        {
            TaskList tasking = new TaskList();

            if (args.Contains("-l"))
            {
                tasking.ListTasks();
            }
            else if (args.Contains("-a"))
            {
                tasking.AddTask(args[1]);
            }
            else if (args.Contains("-r"))
            {
                tasking.RemoveTask(args[1]);
            }
            else
            {
                ReadingArgmnts();
                Console.ReadLine();
            }
        }

        static void ReadingArgmnts()
        {
            string path = @"..\..\assets\welcomemsg.txt";
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
