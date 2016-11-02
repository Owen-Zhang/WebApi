namespace Owen.Site.Core.Log
{
    public class LoggerManager
    {
        static FileLog logger = FileLog.Instance;

        public static void Error(object message)
        {
            logger.Error(message);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            logger.ErrorFormat(format, args);
        }

        public static void InfoFormat(string format, params object[] args)
        {
            logger.InfoFormat(format, args);
        }

        public static void Info(object message)
        {
            logger.Info(message.ToString());
        }
    }
}
