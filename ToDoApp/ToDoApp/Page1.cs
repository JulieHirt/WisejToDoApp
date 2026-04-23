using System.Collections.Generic;
using Wisej.Web;
using Wisej.Web.Markup;

namespace ToDoApp
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

        }

        private void Page1_Load(object sender, System.EventArgs e)
        {
            List<Task> list = new List<Task>();
            list.Add(new Task("Clean Bathroom", "The bathroom's toilet and sink need cleaned"));
            list.Add(new Task("Buy Groceries", "We need milk and eggs"));
            list.Add(new Task("Do laundry", "The laundry basket is full"));

            listBox1.DataSource = list;
            listBox1.DisplayMember = "Name";
        }
    }
}
