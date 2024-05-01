using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface ILogger
    {
        void LogInfo(string message);
        void LogError(string error);

    }
    class Logger : ILogger
    {
        private readonly string _logFilePath;
        private string _logmessage;
        private string _errormessage;
        public string LogFilePath
        {
            get { return _logFilePath; }
            init { _logFilePath = "C:\\Documents"; }
        }

        public string Logmessage
        {
            get { return _logmessage; }
            protected set { _logmessage = value; }
        }

        public string Errormessage
        {
            get => _errormessage;
            protected set { _errormessage = value; }
        }

        public Logger()
        {
                
        }
        public Logger(string logpath)
        {
            LogFilePath = logpath;
        }

        void ILogger.LogInfo(string message)
        {
            Logmessage = DateTime.Now.ToString() + ": " + message;
        }

        void ILogger.LogError(string error)
        {
            Errormessage = DateTime.Now.ToString() + ": " + error;
        }

    }
}
