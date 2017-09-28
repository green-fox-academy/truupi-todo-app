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
        string[] result = File.ReadAllLines(path);

        public void ReadingListTxt()
        {
            if (result.Length == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, result[i]);
                }
            }
        }

        public void AddTask(string inputTask)
        {
            using (StreamWriter srwriter = File.AppendText(path))
                { srwriter.WriteLine(inputTask); }
        }
    }
}
