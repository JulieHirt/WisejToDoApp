using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Markup;

namespace ToDoApp
{
    
    public partial class Page1 : Page
    {
        BindingList<Task> list;
        public event EventHandler<TaskEventArgs> TaskSelected;
        public event EventHandler TaskAdded;
        public event EventHandler TaskCompleted;
        public event EventHandler NoTasksRemaining;


        public Page1()
        {
            InitializeComponent();
            TaskSelected += (s, e) =>
            {
                if (e?.TaskItem == null)
                    return;

                AlertBox.Show("Task selected: " + e.TaskItem.Name);
            };
            NoTasksRemaining += (s, e) =>
            {
                AlertBox.Show("All tasks completed!");
            };
            taskPanel1.Attach(this);
            TaskAdded += UpdateTaskRemaining;
            TaskCompleted += UpdateTaskRemaining;

        }


        public void UpdateTaskRemaining(object sender, EventArgs e)
        {
            label1.Text = "Tasks Remaining: "+list.Count;
        }

        private void Page1_Load(object sender, System.EventArgs e)
        {
            list = new BindingList<Task>();
            list.Add(new Task("Clean Bathroom", "The bathroom's toilet and sink need cleaned", () => { MessageBox.Show("Bathroom Cleaned!"); }));
            list.Add(new Task("Buy Groceries", "We need milk and eggs", GroceriesMethod));
            list.Add(new Task("Do laundry", "The laundry basket is full", LaundryMethod));
            listBox1.DataSource = list;
            listBox1.DisplayMember = "Name";

            TaskAdded?.Invoke(this, new EventArgs());
        }

        public void GroceriesMethod()
        {
            MessageBox.Show("The store was out of eggs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LaundryMethod()
        {
            MessageBox.Show("The dryer is broken, we'll have to air dry the clothes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            list.Add(new Task("new task", "new task description", () => { AlertBox.Show("new task completed!"); }));
            TaskAdded?.Invoke(this, new EventArgs());
        }

        private void listBox1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)listBox1.SelectedItem;

            if (selectedTask == null)
                return;

            TaskSelected?.Invoke(this, new TaskEventArgs(selectedTask));
        }

        private void buttonCompleted_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)listBox1.SelectedItem;
            selectedTask.Action();
            list.Remove(selectedTask);
            if(list.Count == 0)
            {
                NoTasksRemaining.Invoke(this, new EventArgs());
            }
            TaskCompleted?.Invoke(this, new EventArgs());
        }

    }
}
