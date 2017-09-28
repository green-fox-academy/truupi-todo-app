using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class TaskList 
    {
        static string path = @"..\..\assets\todolist.txt";
        static string[] taskArray = File.ReadAllLines(path);

        internal void ListTasks()
        {
            switch (taskArray.Length)
            {
                case 0:
                    Console.WriteLine("No todos for today! :)");
                    break;
                default:
                {
                    WriteTasksToConsole();
                    break;
                }
            }
        }

        internal void WriteTasksToConsole()
        {
            for (int i = 0; i < taskArray.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, taskArray[i]);
            }
        }

        internal void RemoveTask(string taskPlace)
        {
            var taskList = new List<string>(System.IO.File.ReadAllLines(path));
            taskList.RemoveAt(Convert.ToInt32(taskPlace) - 1);

            File.WriteAllLines(path, taskList);
        }

        internal void AddTask(string inputTask)
        {
            using (StreamWriter taskWriter = File.AppendText(path))
                { taskWriter.WriteLine(inputTask); }
        }
    }
}
