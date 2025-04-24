namespace SettingsApp
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
            checkBoxTheme = new CheckBox();
            comboBoxLanguage = new ComboBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // checkBoxTheme
            // 
            checkBoxTheme.AutoSize = true;
            checkBoxTheme.Location = new Point(12, 41);
            checkBoxTheme.Name = "checkBoxTheme";
            checkBoxTheme.Size = new Size(95, 19);
            checkBoxTheme.TabIndex = 0;
            checkBoxTheme.Text = "Темная тема";
            checkBoxTheme.UseVisualStyleBackColor = true;
            checkBoxTheme.CheckedChanged += checkBoxTheme_CheckedChanged;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "English", "Русский" });
            comboBoxLanguage.Location = new Point(12, 12);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(138, 23);
            comboBoxLanguage.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 66);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(78, 26);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxLanguage);
            Controls.Add(checkBoxTheme);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxTheme;
        private ComboBox comboBoxLanguage;
        private Button buttonSave;
    }
}
