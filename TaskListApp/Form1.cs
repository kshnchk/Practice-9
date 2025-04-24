namespace TaskListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                listBoxTasks.Items.Add(textBoxTask.Text);
                textBoxTask.Clear();
            }
            else
            {
                MessageBox.Show("¬ведите задачу.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
          
            if (listBoxTasks.SelectedItem != null)
            {
                listBoxTasks.Items.Remove(listBoxTasks.SelectedItem);
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                
                int index = listBoxTasks.SelectedIndex;
                string task = listBoxTasks.SelectedItem.ToString();

                
                listBoxTasks.Items[index] = new TaskItem(task) { IsCompleted = true };
            }
        }
    }

    public class TaskItem
    {
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string task)
        {
            Task = task;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return IsCompleted ? "@" + Task  : Task;
        }
    }
}

