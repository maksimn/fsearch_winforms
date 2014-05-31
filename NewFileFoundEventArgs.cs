using System;

namespace FilesSearching {
    class NewFileFoundEventArgs : EventArgs {
        private readonly String fullname;
        public NewFileFoundEventArgs(String s) { 
            fullname = s; 
        }
        public String FullName { 
            get { 
                return fullname; 
            } 
        }
    }
}