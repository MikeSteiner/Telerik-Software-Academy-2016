using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskManager.Model;

namespace TaskManager.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            var idProvider = new IdProvider();

            Tasker taskManager = new Tasker(consoleLogger, idProvider);

            var task1 = new Model.Task("Kupi leb");
            var task2 = new Model.Task("Wash the car", DateTime.Now.AddDays(2));
            var task3 = new Model.Task("Kupi bira", DateTime.Now);

            taskManager.Save(task1);
            taskManager.Save(task2);
            taskManager.Delete(2);
            taskManager.Save(task3);

        }
    }
}
