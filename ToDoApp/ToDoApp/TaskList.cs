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
        public void ReadingListTxt()
        {
            string path = @"..\..\assets\todolist.txt";
            string[] result = File.ReadAllLines(path);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, result[i]);
            }
        }
    }
}
