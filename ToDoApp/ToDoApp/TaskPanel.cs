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




        public void UpdateLabels(string name, string description)
        {
            TaskName.Text = name;
            TaskDescription.Text = description; 
        }
            
    }
}
