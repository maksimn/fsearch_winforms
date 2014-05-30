using System;

namespace FilesSearching {
    class NewFileProcessedEventArgs : EventArgs {
        private readonly Int32 num;
        private readonly String fname, time;
        public NewFileProcessedEventArgs(Int32 n, String filename, String stime) {
            num = n; fname = filename; time = stime;
        }
        public Int32 NumFiles { get { return num; } }
        public String FileName { get { return fname; } }
        public String Time { get { return time; } }
    }
}