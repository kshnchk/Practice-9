namespace WinFormsApp2
{
    partial class Form1
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
            textBoxName = new TextBox();
            buttonGreet = new Button();
            labelGreeting = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(30, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(145, 23);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Введите имя";
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // buttonGreet
            // 
            buttonGreet.Location = new Point(30, 69);
            buttonGreet.Name = "buttonGreet";
            buttonGreet.Size = new Size(145, 23);
            buttonGreet.TabIndex = 1;
            buttonGreet.Text = "Поприветствовать";
            buttonGreet.UseVisualStyleBackColor = true;
            buttonGreet.Click += button1_Click;
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Location = new Point(30, 95);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(0, 15);
            labelGreeting.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelGreeting);
            Controls.Add(buttonGreet);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Button buttonGreet;
        private Label labelGreeting;
    }
}
