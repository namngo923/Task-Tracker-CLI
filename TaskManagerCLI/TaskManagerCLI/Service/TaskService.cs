using System.Collections.Generic;
using System.Linq;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public void AddTask(TaskItemAdd taskItemAdd)
        {
            var task = new TaskItem
            {
                Id = _nextId++,
                Title = taskItemAdd.Title,
                Description = taskItemAdd.Description,
                Assigner = taskItemAdd.Assigner,
                CreatedAt = DateTime.Now,
                IsCompleted = false
            };
            _tasks.Add(task);
        }

        public IEnumerable<TaskItem> GetTasks()
        {
            return _tasks;
        }

        public TaskItem GetTaskDetail(int taskId)
        {
            return  _tasks.FirstOrDefault(t => t.Id == taskId);
        }

        public bool RemoveTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                _tasks.Remove(task);
                return true;
            }
            return false;
        }

        public bool UpdateTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(task => task.Id == taskId);
            if (task != null)
            {
                task.IsCompleted = true;
                return true;
            }
            return false;
        }
    }
}
