namespace FilesSearching {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textInFileTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currFileLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qtyFilesLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Директория для поиска:";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(16, 30);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(182, 20);
            this.folderTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Задать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Файл:";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(16, 74);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(229, 20);
            this.fileTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Текст в файле:";
            // 
            // textInFileTextBox
            // 
            this.textInFileTextBox.Location = new System.Drawing.Point(16, 118);
            this.textInFileTextBox.Multiline = true;
            this.textInFileTextBox.Name = "textInFileTextBox";
            this.textInFileTextBox.Size = new System.Drawing.Size(229, 48);
            this.textInFileTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Обрабатывается файл:";
            // 
            // currFileLabel
            // 
            this.currFileLabel.AutoSize = true;
            this.currFileLabel.Location = new System.Drawing.Point(148, 211);
            this.currFileLabel.Name = "currFileLabel";
            this.currFileLabel.Size = new System.Drawing.Size(0, 13);
            this.currFileLabel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Обработано файлов:";
            // 
            // qtyFilesLabel
            // 
            this.qtyFilesLabel.AutoSize = true;
            this.qtyFilesLabel.Location = new System.Drawing.Point(135, 228);
            this.qtyFilesLabel.Name = "qtyFilesLabel";
            this.qtyFilesLabel.Size = new System.Drawing.Size(0, 13);
            this.qtyFilesLabel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Прошло времени:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(119, 245);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 12;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(19, 294);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(100, 294);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 14;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(265, 13);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(432, 406);
            this.treeView.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 431);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qtyFilesLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currFileLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textInFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск файлов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosedHandler);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textInFileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currFileLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label qtyFilesLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TreeView treeView;
    }
}

