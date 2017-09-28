using System;
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
            Welcome();
        }

        static void Welcome()
        {
            Console.WriteLine("\nCommand Line Todo Application\n" + "=============================\n\n" + "Command line arguments:\n" + "-l   Lists all the tasks\n" +
                "-a   Adds a new task\n" + "-r   Removes a task\n" + "-c   Completes a task\n");
            Console.ReadLine();
        }
    }
}
