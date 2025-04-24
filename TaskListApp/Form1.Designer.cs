namespace TaskListApp
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
            textBoxTask = new TextBox();
            buttonAdd = new Button();
            listBoxTasks = new ListBox();
            buttonRemove = new Button();
            buttonComplete = new Button();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(215, 12);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(165, 23);
            textBoxTask.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(215, 41);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(60, 26);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(215, 73);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(165, 94);
            listBoxTasks.TabIndex = 2;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(305, 173);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Удалить";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(215, 173);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(75, 23);
            buttonComplete.TabIndex = 4;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonComplete);
            Controls.Add(buttonRemove);
            Controls.Add(listBoxTasks);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask;
        private Button buttonAdd;
        private ListBox listBoxTasks;
        private Button buttonRemove;
        private Button buttonComplete;
    }
}
