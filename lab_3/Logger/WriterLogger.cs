using System;
using System.IO;
using System.Text;
using System.Net.Sockets;

namespace lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messeges)
        {
            DateTime time = DateTime.Now;
            //(time.ToString();
            writer.Write(time.ToString("yyyy-MM-ddTHH:mm:sszzz "));

            foreach (var messege in messeges)
            {
                writer.Write(messege + " ");
            }
            writer.Write("\n");
            writer.Flush();
        }

        public abstract void Dispose();
    }
}
