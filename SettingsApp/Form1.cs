namespace SettingsApp
{
    public partial class Form1 : Form
    {
        private string settingsFilePath = "settings.ini";

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {

            if (File.Exists(settingsFilePath))
            {
                var settings = File.ReadAllLines(settingsFilePath);


                checkBoxTheme.Checked = settings.Length > 0 && settings[0] == "Dark";


                if (settings.Length > 1)
                {
                    comboBoxLanguage.SelectedItem = settings[1];
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {

                writer.WriteLine(checkBoxTheme.Checked ? "Dark" : "Light");

                writer.WriteLine(comboBoxLanguage.SelectedItem?.ToString() ?? "English");
            }

            MessageBox.Show("Настройки сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTheme.Checked)
            {
                this.BackColor = System.Drawing.Color.Black;
                this.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
            }

            this.ForeColor = System.Drawing.Color.Black;
        }
    }

}


