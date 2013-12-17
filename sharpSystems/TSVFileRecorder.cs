using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class TSVFileRecorder : IRecord, IWriteFile
    {
        #region Variable declarations
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
        #endregion 

        #region Constructor Declarations
        // CONSTRUCTOR DECLARATIONS
        public TSVFileRecorder(string filePath)
        {
            FilePath = filePath;

        }
        #endregion

        #region Methods declarations

        /// <summary>
        /// Opens FileBuffer with provided path
        /// </summary>
        public void Open()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            fs = File.Open(filePath, FileMode.OpenOrCreate);
            isFileStreamOpen = true;
        }

        /// <summary>
        /// Receives a ReportEntry, and sends it to RecordEntry, where it is saved to file;
        /// </summary>
        /// <param name="entry"></param>
        public void Receive(ReportEntry entry)
        {
            RecordEntry(entry.ToString());
        }

        /// <summary>
        /// Takes a string and records it in the buffer.
        /// </summary>
        /// <param name="entryLine"></param>
        private void RecordEntry(String entryLine)
        {
            UnicodeEncoding uniEnc = new UnicodeEncoding();
            if (fs.CanWrite)
            {
                fs.Write(uniEnc.GetBytes(entryLine), 0, uniEnc.GetByteCount(entryLine));
            }

        }
        /// <summary>
        /// Closes the FileBuffer
        /// </summary>
        public void Close()
        {
            fs.Close();
            IsFileStreamOpen = false;
        }
        #endregion
    }
}
