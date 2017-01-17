using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    public class Tasker
    {
        private ILogger logger;
        private IdProvider idProvider;

        public ICollection<Task> Tasks { get; set; }

        public Tasker(ILogger logger, IIdProvider idProvider)
        {
            this.Tasks = new List<Task>();

            this.logger = logger;
            this.idProvider = new IdProvider();
        } 

        // Save(task)
        public void Save(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException();
            }

            // Generate id for the new added task;
            task.Id = this.idProvider.Id;
            this.Tasks.Add(task);
            string logMsg = string.Format("Task {0} is saved!", task.Description);
            this.logger.Log(logMsg);
            
        }

        // Delete(int taskId)
        public void Delete(int id)
        {
            string logMsg = string.Empty;
            Task taskToDelete = this.Tasks
                .SingleOrDefault(t => t.Id == id);
            
            if (taskToDelete == null)
            {
                logMsg = string.Format("Task with id {0} can not be found!", id);
                this.logger.Log(logMsg);

                return;
            }

            Tasks.Remove(taskToDelete);
            logMsg = string.Format("Task {0} with id {1} is deleted!", taskToDelete.Description, taskToDelete.Id);
            this.logger.Log(logMsg);
        }

        // TODO MarkAsDone(int taskId);

        // All Tasksks to the logger();
        public void AllTasks()
        {
            foreach (var task in this.Tasks)
            {
                string msg = string.Format("Task {0} whith id {1}", task.Description, task.Id);
                this.logger.Log(msg);
            }
        }
    }
}
