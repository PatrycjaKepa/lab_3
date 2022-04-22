using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Logger
{
    internal class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Log(params string[] messages)
        {
            foreach(var logger in this.loggers)
            {
                logger.Log(messages);
            }
        }

        public void Dispose()
        {
            //TODO
        }

    }
}
