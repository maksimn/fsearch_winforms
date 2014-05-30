using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FilesSearching {
    // FileSearcher class encapsulate logics to find files 
    class FileSearcher {
        // Nested types:
        private enum FilesSearchingMode { Name, Text, NameAndText }

        // Properties:
        public Int32 NumFiles { get; set; } // Number of files processed
        public String Directory { get; set; }
        public String FilePattern { get; set; }
        public String TextPattern { get; set; }
        public TimeSpan Time { get; set; }

        // Events:
        public event EventHandler<NewFileProcessedEventArgs> NewFileProcessed;
        public event EventHandler<NewFileFoundEventArgs> NewFileFound;

        // Fields:
        private CancellationTokenSource cts;
        private DateTime beginning;
        private FilesSearchingMode fsm;

        // Methods:
        public async Task StartSearching() {
            await Task.Run(() => { FindFiles(new DirectoryInfo(Directory)); });
        }

        private void FindFiles(DirectoryInfo dir) {
            beginning = DateTime.Now;
            cts = new CancellationTokenSource();
            SetFileSearchingMode();
            ProcessDirectories(dir, cts.Token);
        }

        private void ProcessDirectories(DirectoryInfo dir, CancellationToken token) {
            if (token.IsCancellationRequested) {
                return;
            }
            try {
                DirectoryInfo[] subdirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                foreach (var subdir in subdirs) {
                    ProcessDirectories(subdir, token);
                }
                foreach (var file in files) {
                    NumFiles++;
                    Time = DateTime.Now.Subtract(beginning);
                    OnNewFileProcessed(new NewFileProcessedEventArgs(NumFiles, file.Name, Time.ToString().Substring(0, 11)));
                    switch (fsm) {
                        case FilesSearchingMode.Name: {
                            FileProcessingNameMode(file);
                            break;
                        }
                        case FilesSearchingMode.Text: {
                            break;
                        }
                        case FilesSearchingMode.NameAndText: {
                            break;
                        }
                        default: break;
                    }
                }
            } catch (Exception) {
            }
        }

        protected virtual void OnNewFileProcessed(NewFileProcessedEventArgs e) {
            RaiseEvent(e, ref NewFileProcessed);
        }

        protected virtual void OnNewFileFound(NewFileFoundEventArgs e) {
            RaiseEvent(e, ref NewFileFound);
        }

        private void RaiseEvent<TEventArgs>(TEventArgs e, ref EventHandler<TEventArgs> eventDelegate) {
            EventHandler<TEventArgs> temp = Volatile.Read(ref eventDelegate);
            if (temp != null) {
                temp(this, e);
            }
        }

        public void Stop() {
            cts.Cancel();
        }

        private void SetFileSearchingMode() {
            if (TextPattern == String.Empty) {
                fsm = FilesSearchingMode.Name;
            } else if (FilePattern == String.Empty && TextPattern != String.Empty) {
                fsm = FilesSearchingMode.Text;
            } else {
                fsm = FilesSearchingMode.NameAndText;
            }
        }

        private void FileProcessingNameMode(FileInfo file) {
            if (file.Name.Contains(FilePattern)) {
                OnNewFileFound(new NewFileFoundEventArgs(file.FullName));
            }
        }
    }
}