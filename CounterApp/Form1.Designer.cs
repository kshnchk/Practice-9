namespace CounterApp
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
            textBoxInitialCount = new TextBox();
            buttonIncrement = new Button();
            buttonSetInitial = new Button();
            labelCount = new Label();
            SuspendLayout();
            // 
            // textBoxInitialCount
            // 
            textBoxInitialCount.Location = new Point(42, 36);
            textBoxInitialCount.Name = "textBoxInitialCount";
            textBoxInitialCount.Size = new Size(182, 23);
            textBoxInitialCount.TabIndex = 0;
            // 
            // buttonIncrement
            // 
            buttonIncrement.Location = new Point(42, 78);
            buttonIncrement.Name = "buttonIncrement";
            buttonIncrement.Size = new Size(88, 23);
            buttonIncrement.TabIndex = 1;
            buttonIncrement.Text = "Инкремент";
            buttonIncrement.UseVisualStyleBackColor = true;
            buttonIncrement.Click += buttonIncrement_Click;
            // 
            // buttonSetInitial
            // 
            buttonSetInitial.Location = new Point(136, 76);
            buttonSetInitial.Name = "buttonSetInitial";
            buttonSetInitial.Size = new Size(123, 25);
            buttonSetInitial.TabIndex = 2;
            buttonSetInitial.Text = "Установить нач ур";
            buttonSetInitial.UseVisualStyleBackColor = true;
            buttonSetInitial.Click += buttonSetInitial_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(233, 44);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(0, 15);
            labelCount.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCount);
            Controls.Add(buttonSetInitial);
            Controls.Add(buttonIncrement);
            Controls.Add(textBoxInitialCount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInitialCount;
        private Button buttonIncrement;
        private Button buttonSetInitial;
        private Label labelCount;
    }
}
