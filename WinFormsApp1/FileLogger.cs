using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class FileLogger : Logger, ILogger
    {
        private Logger _Logger;
        private int _logtype;

        public int Logtype
        {
            protected get => _logtype;
            init { _logtype = value; }
        }

        public FileLogger(int filetype, string logpath) : base(logpath)
        {
            _Logger = new Logger(logpath);
            switch (filetype)
            {
                case 1:
                    Logtype = filetype; //".txt"
                    break;
                case 2:
                    Logtype = filetype; //".json"
                    break;

                default:
                    Errormessage = "unknown filetype";
                    break;
            }

        }

        void ILogger.LogInfo(string message)
        {
            switch (Logtype)
            {
                case 1:
                    using (StreamWriter outfile = new StreamWriter(LogFilePath + "\\Log.txt"))
                    {
                        Logmessage = (DateTime.Now.ToString() + ": " + message);
                        outfile.WriteLine(Logmessage);
                    }
                    break;

                default:
                    Errormessage = "unknown filetype";
                    break;
            }
            
        }

        void ILogger.LogError(string error)
        {
            switch (Logtype)
            {
                case 1:
                    using (StreamWriter outfile = new StreamWriter(_Logger.LogFilePath + "\\ErrorRep.txt"))
                    {
                        Errormessage = (DateTime.Now.ToString() + ": " + error);
                        outfile.WriteLine(Errormessage);
                    }
                    break;

                default:
                    Errormessage = "unknown filetype";
                    break;
            }
            
        }
    }
}
