using System;

namespace ToDoApp
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Task(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    public class TaskSelectedEventArgs: EventArgs
    { 
        public Task TaskItem { get; }

        public TaskSelectedEventArgs(Task taskItem)
        {
            TaskItem = taskItem;
        }
    }
}
