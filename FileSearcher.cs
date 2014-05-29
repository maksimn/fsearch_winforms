using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FilesSearching {
    // FileSearcher class encapsulate logics to find files 
    class FileSearcher {
        // Nested types:
        private enum FilesSearchingMode {
            Name,
            Text,
            NameAndText
        }

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

        // Methods:
        public async Task StartSearching() {
            await Task.Run(() => { FindFiles(new DirectoryInfo(Directory)); });
        }

        private void FindFiles(DirectoryInfo dir) {
            beginning = DateTime.Now;
            cts = new CancellationTokenSource();
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
                    OnNewFileProcessed(new NewFileProcessedEventArgs());
                    if (file.Name.Contains(FilePattern)) {
                        OnNewFileFound(new NewFileFoundEventArgs(file.FullName));
                    }
                }
            } catch (Exception) {
            }
        }

        protected virtual void OnNewFileProcessed(NewFileProcessedEventArgs e) {
            EventHandler<NewFileProcessedEventArgs> temp = Volatile.Read(ref NewFileProcessed);
            if (temp != null) {
                temp(this, e);
            }
        }

        protected virtual void OnNewFileFound(NewFileFoundEventArgs e) {
            EventHandler<NewFileFoundEventArgs> temp = Volatile.Read(ref NewFileFound);
            if (temp != null) {
                temp(this, e);
            }
        }

        public void Stop() {
            cts.Cancel();
        }
    }
}