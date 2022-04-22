using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Logger
{
    internal class FileLogger : WriterLogger, IDisposable
    {
        private bool disposed;

        protected FileStream stream;

        public FileLogger(String path)
        {
            FileStream stream = new FileStream(path , FileMode.Append);
            writer = new StreamWriter(stream, Encoding.UTF8);
        }

        ~FileLogger()
        {
            this.Dispose();
            writer.Close();
        }

        public override void Dispose()
        {
            if (!this.disposed)
            {
                this.disposed = true;
            }
        }
    }
}
