using System;
using Wisej.Web;

namespace ToDoApp
{
    public partial class TaskPanel : Wisej.Web.UserControl
    {
        public TaskPanel()
        {
            InitializeComponent();
        }

        public void Attach(Page1 page)
        {
            page.TaskSelected += OnTaskSelected;
            page.NoTasksRemaining += OnNoTasksRemaining;
        }

        private void OnTaskSelected(object sender, TaskEventArgs e)
        {
            if (e?.TaskItem == null)
                return;

            UpdateLabels(e.TaskItem.Name, e.TaskItem.Description);
        }

        private void OnNoTasksRemaining(object sender, EventArgs e)
        {
            UpdateLabels("", "");
        }


        private void UpdateLabels(string name, string description)
        {
            TaskName.Text = name;
            TaskDescription.Text = description; 
        }
            
    }
}
