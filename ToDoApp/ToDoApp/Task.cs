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

    public class TaskEventArgs: EventArgs
    { 
        public Task TaskItem { get; }

        public TaskEventArgs(Task taskItem)
        {
            TaskItem = taskItem;
        }
    }
}
