namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string greeting = "Привет, " + textBoxName.Text + "!";
            labelGreeting.Text = greeting;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
