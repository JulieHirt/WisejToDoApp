namespace ToDoApp
{
    partial class TaskPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskName = new Wisej.Web.Label();
            this.TaskDescription = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Location = new System.Drawing.Point(16, 22);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(66, 18);
            this.TaskName.TabIndex = 0;
            this.TaskName.Text = "Task Name";
            // 
            // TaskDescription
            // 
            this.TaskDescription.AutoSize = true;
            this.TaskDescription.Location = new System.Drawing.Point(16, 57);
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.Size = new System.Drawing.Size(97, 18);
            this.TaskDescription.TabIndex = 1;
            this.TaskDescription.Text = "Task Description";
            // 
            // TaskPanel
            // 
            this.BackColor = System.Drawing.Color.FromName("@table-row-background-focused");
            this.Controls.Add(this.TaskDescription);
            this.Controls.Add(this.TaskName);
            this.Name = "TaskPanel";
            this.Size = new System.Drawing.Size(521, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label TaskName;
        private Wisej.Web.Label TaskDescription;
    }
}
