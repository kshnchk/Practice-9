namespace задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    textBox1.Text += '1';
                    break;
                case '2':
                    textBox1.Text += '2';
                    break;
                case '3':
                    textBox1.Text += '3';
                    break;
                case '4':
                    textBox1.Text += '4';
                    break;
                case '5':
                    textBox1.Text += '5';
                    break;
                case '6':
                    textBox1.Text += '6';
                    break;
                case '7':
                    textBox1.Text += '7';
                    break;
                case '8':
                    textBox1.Text += '8';
                    break;
                case '9':
                    textBox1.Text += '9';
                    break;
                case '0':
                    textBox1.Text += '0';
                    break;
                case '+':
                    textBox1.Text += " + ";
                    break;
                case '-':
                    textBox1.Text += " - ";
                    break;
                case 'x':
                    textBox1.Text += " x ";
                    break;
                case ':':
                    textBox1.Text += " : ";
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += " x ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += " : ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;

            string[] parts = expression.Split(new[] { ' ' });

                if (parts.Length == 3)

                {
                    double num1 = Convert.ToDouble(parts[0]); 

                    string operation = parts[1]; 

                    double num2 = Convert.ToDouble(parts[2]); 

                    double result = 0;
                
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "x":
                        case "*":
                            result = num1 * num2;
                            break;
                        case ":":
                        case "/":
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                        else
                        {
                            
                            MessageBox.Show("Ошибка: Деление на ноль невозможно.");
                            return; 
                        }
                        break;

                    default:
                        MessageBox.Show("Ошибка: Некорректная операция."); 
                    return;

                }
                    textBox1.Text = result.ToString();
                }

                else
                {
                    MessageBox.Show("Введите правильное выражение в формате: число знак число.");
                }
        }
    }

}

