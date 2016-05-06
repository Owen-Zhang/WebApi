using NLog;
namespace Owen.Site.Core.Log
{
    public class LoggerManager
    {
        static LoggerManager _loggerManager;
        public static LoggerManager Instance 
        {
            get {
             if (_loggerManager == null)
                _loggerManager = new LoggerManager();

             return _loggerManager;
            }   
        }

        Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void Info(string message, params object[] args)
        {
            logger.Info(message, args);
        }

        public void Debug(string message, params object[] args)
        {
            logger.Debug(message, args);
        }

        public void Error(string message, params object[] args)
        {
            logger.Error(message, args);
        }

        public void Fatal(string message, params object[] args)
        {
            logger.Fatal(message, args);
        }
    }
}
