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
            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu2 = new Wisej.Web.ContextMenu(this.components);
            this.label1 = new Wisej.Web.Label();
            this.listBox1 = new Wisej.Web.ListBox();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.taskPanel1 = new ToDoApp.TaskPanel();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // contextMenu2
            // 
            this.contextMenu2.Name = "contextMenu2";
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Task";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Complete Task";
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1018, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.Label label1;
        private Wisej.Web.ListBox listBox1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
        private TaskPanel taskPanel1;
    }
}
