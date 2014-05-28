using System;
using System.Windows.Forms;

namespace FilesSearching {
    public partial class MainForm : Form {
        // Fields:
        private FolderBrowserDialog folderBrowserDialog;
        private FileSearcher fileSearcher;

        // Methods:
        public MainForm() {
            InitializeComponent();
            SetInitialValuesInTextBoxes();

            fileSearcher = new FileSearcher();
            fileSearcher.NewFileProcessed += NewFileProcessedMsg;
            fileSearcher.NewFileFound += NewFileFoundMsg;
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

        private void NewFileProcessedMsg(Object o, NewFileProcessedEventArgs e) {
            qtyFilesLabel.Invoke(new Action<Int32>((num) => qtyFilesLabel.Text = num.ToString()), fileSearcher.NumFiles);
            timeLabel.Invoke(new Action<String>((str) => timeLabel.Text = str), fileSearcher.Time.ToString().Substring(0, 11));
        }

        private void NewFileFoundMsg(Object o, NewFileFoundEventArgs e) {
//            treeView.Invoke(new Action<String>(str => AddInformationInTreeView(str)), e.FullName);
        }
    }
}
