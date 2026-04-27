using System;

namespace ToDoApp
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Action Action { get; set; }

        public Task(string name, string description, Action action)
        {
            Name = name;
            Description = description;
            Action = action;
        }
    }

    public class TaskEventArgs: EventArgs
    { 
        public Task TaskItem { get; }

        public TaskEventArgs(Task taskItem)
        {
            TaskItem = taskItem;
        }
    }
}
