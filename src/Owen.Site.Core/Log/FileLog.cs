using System;
using NLog;
using ServiceStack.Logging;
namespace Owen.Site.Core.Log
{
    public class FileLog : ILog
    {
        static FileLog _fileLog;
        public static FileLog Instance 
        {
            get {
                if (_fileLog == null)
                    _fileLog = new FileLog();

                return _fileLog;
            }   
        }
        
        Logger logger = NLog.LogManager.GetCurrentClassLogger();
        
        public void Debug(object message, System.Exception exception)
        {

        }

        public void Debug(object message)
        {
            //logger.Debug(message);
        }

        public void DebugFormat(string format, params object[] args)
        {
            //logger.Debug(format, args);
        }

        public void Error(object message)
        {
            logger.Error(message);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            logger.Error(format, args);
        }

        public void Fatal(object message)
        {
            logger.Fatal(message);
        }

        public void FatalFormat(string format, params object[] args)
        {
            logger.Fatal(format, args);
        }

        public void Info(object message)
        {
            logger.Info(message);
        }

        public void InfoFormat(string format, params object[] args)
        {
            logger.Info(format, args);
        }

        public bool IsDebugEnabled { get; set; }

        public void Warn(object message)
        {
            logger.Warn(message);
        }

        public void WarnFormat(string format, params object[] args)
        {
            logger.Warn(format, args);
        }


        /*暂时不用的方法，由于实现了接口，写个空的方法*/

        public void Error(object message, Exception exception){ }
        public void Fatal(object message, Exception exception) { }
        public void Info(object message, Exception exception) { }
        public void Warn(object message, Exception exception) { }
    }
}
