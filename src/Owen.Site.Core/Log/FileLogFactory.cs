using ServiceStack.Logging;

namespace Owen.Site.Core.Log
{
    public class FileLogFactory : ILogFactory
    {
        public ILog GetLogger(string typeName)
        {
            return new FileLog();
        }

        public ILog GetLogger(System.Type type)
        {
            return new FileLog();
        }
    }
}
