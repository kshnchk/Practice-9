namespace TemperatureConverter
{
    partial class ConvertForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCelsiusToFahrenheit = new Button();
            buttonFahrenheitToCelsius = new Button();
            textBoxTemperature = new TextBox();
            labelResult = new Label();
            SuspendLayout();
            // 
            // buttonCelsiusToFahrenheit
            // 
            buttonCelsiusToFahrenheit.Location = new Point(67, 50);
            buttonCelsiusToFahrenheit.Name = "buttonCelsiusToFahrenheit";
            buttonCelsiusToFahrenheit.Size = new Size(200, 22);
            buttonCelsiusToFahrenheit.TabIndex = 0;
            buttonCelsiusToFahrenheit.Text = "Преобразовать в Ф";
            buttonCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            buttonCelsiusToFahrenheit.Click += buttonCelsiusToFahrenheit_Click;
            // 
            // buttonFahrenheitToCelsius
            // 
            buttonFahrenheitToCelsius.Location = new Point(273, 48);
            buttonFahrenheitToCelsius.Name = "buttonFahrenheitToCelsius";
            buttonFahrenheitToCelsius.Size = new Size(200, 23);
            buttonFahrenheitToCelsius.TabIndex = 1;
            buttonFahrenheitToCelsius.Text = "Преобразовать в Ц";
            buttonFahrenheitToCelsius.UseVisualStyleBackColor = true;
            // 
            // textBoxTemperature
            // 
            textBoxTemperature.Location = new Point(67, 19);
            textBoxTemperature.Name = "textBoxTemperature";
            textBoxTemperature.Size = new Size(406, 23);
            textBoxTemperature.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(498, 27);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 3;
            labelResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(textBoxTemperature);
            Controls.Add(buttonFahrenheitToCelsius);
            Controls.Add(buttonCelsiusToFahrenheit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCelsiusToFahrenheit;
        private Button buttonFahrenheitToCelsius;
        private TextBox textBoxTemperature;
        private Label labelResult;
    }
}
