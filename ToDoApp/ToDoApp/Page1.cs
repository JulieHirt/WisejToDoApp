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
        public event EventHandler<TaskSelectedEventArgs> TaskSelected;

        public Page1()
        {
            InitializeComponent();
            TaskSelected += (s, e) =>
            {
                taskPanel1.UpdateLabels(e.TaskItem.Name, e.TaskItem.Description);
            };

        }

        private void Page1_Load(object sender, System.EventArgs e)
        {
            list = new BindingList<Task>();
            list.Add(new Task("Clean Bathroom", "The bathroom's toilet and sink need cleaned"));
            list.Add(new Task("Buy Groceries", "We need milk and eggs"));
            list.Add(new Task("Do laundry", "The laundry basket is full"));

            listBox1.DataSource = list;
            listBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            list.Add(new Task("new task", "new task description"));
        }

        private void listBox1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)listBox1.SelectedItem;
            TaskSelected?.Invoke(this, new TaskSelectedEventArgs(selectedTask));
        }
    }
}
