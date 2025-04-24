namespace TemperatureConverter
    {
        public partial class ConvertForm1 : Form
        {
            public ConvertForm1()
            {
                InitializeComponent();
            }

            private void buttonCelsiusToFahrenheit_Click(object sender, EventArgs e)
            {
                try
                {
                    double celsius = double.Parse(textBoxTemperature.Text); 
                    double fahrenheit = (celsius * 9 / 5) + 32; 
                    labelResult.Text = fahrenheit.ToString() + " °F"; 
                }
                catch (FormatException)
                {
                    MessageBox.Show("Пожалуйста, введите правильное число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void buttonFahrenheitToCelsius_Click(object sender, EventArgs e)
            {
                try
                {
                    double fahrenheit = double.Parse(textBoxTemperature.Text); 
                    double celsius = (fahrenheit - 32) * 5 / 9; 
                    labelResult.Text = celsius.ToString() + " °C"; 
                }
                catch (FormatException)
                {
                    MessageBox.Show("Пожалуйста, введите правильное число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
}


