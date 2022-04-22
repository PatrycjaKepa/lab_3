using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Logger
{
    internal class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;

        //package
        public  SocketLogger(string host, int port)
        {
             this.clientSocket = new ClientSocket (host, port);
        }

        ~SocketLogger()
        {
            this.Dispose();
            this.clientSocket.Close ();
        }

        public void Log(params string[] messages)
        {
            DateTime time = DateTime.Now;   
            string messageToSend = time.ToString("yyyy-MM-ddTHH:mm:sszzz ");

            foreach (string message in messages)
            {
                messageToSend += message + " ";
            }

            byte[] requestBytes = Encoding.UTF8.GetBytes(messageToSend);
            clientSocket.Send(requestBytes);
        }

        public virtual void Dispose()
        {
            clientSocket.Dispose();
        }

    }
}
