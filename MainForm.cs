using System;
using System.Windows.Forms;

namespace FilesSearching {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            SetInitialValuesInTextBoxes();
        }

        private void SetInitialValuesInTextBoxes() {
            folderTextBox.Text = Properties.Settings.Default.Folder;
            fileTextBox.Text = Properties.Settings.Default.FileName;
            textInFileTextBox.Text = Properties.Settings.Default.FileContent;
        }

        private void SaveSettingsOfTextBoxes() {
            Properties.Settings.Default.Folder = folderTextBox.Text;
            Properties.Settings.Default.FileName = fileTextBox.Text;
            Properties.Settings.Default.FileContent = textInFileTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void MainFormClosedHandler(object sender, FormClosedEventArgs e) {
            SaveSettingsOfTextBoxes();
        }
    }
}
