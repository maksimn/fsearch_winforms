using System;

namespace FilesSearching {
    class NewFileProcessedEventArgs : EventArgs {
        private readonly String fname;
        public NewFileProcessedEventArgs(String filename) {
            fname = filename;
        }
        public String FileName { 
            get { 
                return fname; 
            } 
        }
    }
}