using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ToDoApp
{
    class TaskList 
    {
        static string path = @"..\..\assets\todolist.txt";
        static string[] taskArray = File.ReadAllLines(path);

        string emptyBox = "[ ]";
        string checkedBox = "[x]";

        internal void ListTasks()
        {
            if (taskArray.Length == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                WriteTasksToConsole();
            }
        }

        internal void RemoveTask(string argsPlace)
        {
            var taskList = new List<string>(File.ReadAllLines(path));
            if (taskList.Count >= 2)
            {
                taskList.RemoveAt(Convert.ToInt32(argsPlace) - 1);
                File.WriteAllLines(path, taskList);
            }
        }

        internal void CheckTask(string inputPlace)
        {
            int argsPlace = (Convert.ToInt32(inputPlace));
            var taskList = new List<string>(File.ReadAllLines(path));
            string[] taskToOverwrite = taskList[(argsPlace - 1)].Split(']');
            taskList.Insert((argsPlace - 1), $"{checkedBox} {taskToOverwrite[1].Trim(' ')}");
            File.WriteAllLines(path, taskList);
            RemoveTask((argsPlace + 1).ToString());
        }

        internal void AddTask(string[] args)
        {
            if (args.Count() == 1)
            {
                Console.WriteLine("Unable to add: no task provided");
            }
            else
            {
                using (StreamWriter taskWriter = File.AppendText(path)) { taskWriter.WriteLine("{0} {1}", emptyBox, args[1]); }
            }
        }

        internal void WriteTasksToConsole()
        {
            for (int i = 0; i < taskArray.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, taskArray[i]);
            }
        }
    }
}
