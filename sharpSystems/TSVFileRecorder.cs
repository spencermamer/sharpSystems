using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class TSVFileRecorder : IRecord, IWriteFile
    {
        private bool isFileStreamOpen;

        public bool IsFileStreamOpen
        {
            get { return isFileStreamOpen; }
            set { isFileStreamOpen = value; }
        }

        protected StreamWriter sw;

        protected FileStream fs;

        private string filePath;
       
        public string FilePath
        {
            get { return filePath; }
            private set { filePath = value; }
        }

        // CONSTRUCTOR DECLARATIONS
        public TSVFileRecorder(string filePath)
        {
            FilePath = filePath;
           
        }


        public void Open() 
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            fs = File.Open(filePath, FileMode.OpenOrCreate);
            isFileStreamOpen = true;
        }

        public async void Receive(ReportEntry entry)
        {
               
        }


        private async void RecordEntry(String entryLine)
        {
            throw new NotImplementedException();
        }
    

public void Close()
{
 	throw new NotImplementedException();
}
}
}
