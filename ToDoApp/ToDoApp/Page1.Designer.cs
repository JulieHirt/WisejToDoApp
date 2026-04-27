namespace ToDoApp
{
    partial class Page1
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
            this.label1 = new Wisej.Web.Label();
            this.listBox1 = new Wisej.Web.ListBox();
            this.buttonAdd = new Wisej.Web.Button();
            this.buttonCompleted = new Wisej.Web.Button();
            this.taskPanel1 = new ToDoApp.TaskPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks Remaining:";
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(19, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 230);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 287);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 42);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Task";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCompleted
            // 
            this.buttonCompleted.Location = new System.Drawing.Point(142, 290);
            this.buttonCompleted.Name = "buttonCompleted";
            this.buttonCompleted.Size = new System.Drawing.Size(100, 37);
            this.buttonCompleted.TabIndex = 3;
            this.buttonCompleted.Text = "Complete Task";
            this.buttonCompleted.Click += new System.EventHandler(this.buttonCompleted_Click);
            // 
            // taskPanel1
            // 
            this.taskPanel1.Location = new System.Drawing.Point(276, 18);
            this.taskPanel1.Name = "taskPanel1";
            this.taskPanel1.Size = new System.Drawing.Size(416, 254);
            this.taskPanel1.TabIndex = 4;
            // 
            // Page1
            // 
            this.Controls.Add(this.taskPanel1);
            this.Controls.Add(this.buttonCompleted);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1229, 557);
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.Label label1;
        private Wisej.Web.ListBox listBox1;
        private Wisej.Web.Button buttonAdd;
        private Wisej.Web.Button buttonCompleted;
        private TaskPanel taskPanel1;
    }
}
