using System.Collections.Specialized;
using System.Web;

namespace Owen.Site.Core.Common
{
    public class AppContext
    {
        static readonly string Identity = "APPCONTEXT";
        private AppContext()
        { 
            
        }

        public string ContentType
        {
            get;
            private set;
        }

        public string AcceptType
        {
            get;
            private set;
        }

        public static AppContext Current
        {
            get {
                if (HttpContext.Current == null) return null;

                AppContext context = HttpContext.Current.Items[Identity] as AppContext;
                if (context == null)
                {
                    context = new AppContext();
                    context.ContentType = context.GetRequestContentType();
                    context.AcceptType = context.GetResponseContentType();
                    HttpContext.Current.Items[Identity] = context;
                }
                return context;
            }     
        }

        /*
        /// <summary>
        /// 得到当前用户的一些详细个人信息, 可以把那部分数据缓存起来
        /// </summary>
        public UserInfo User 
        {
            get
            {
                return RedisData.Get<UserInfo>(HttpContext.Current.Request.Headers["UserName"]);
            }
        }*/

        private string GetRequestContentType()
        {
            string contentType = string.Empty;

            NameValueCollection headers = HttpContext.Current.Request.Headers;
            if (headers.HasKeys() && !string.IsNullOrWhiteSpace(headers[Constant.ContentType]))
            {
                contentType = headers[Constant.ContentType].Trim();
                //do other check
            }
            return contentType;
        }

        private string GetResponseContentType()
        {
            string contentType = string.Empty;

            NameValueCollection headers = HttpContext.Current.Request.Headers;
            if (headers.HasKeys() && !string.IsNullOrWhiteSpace(headers[Constant.AccetpType]))
            {
                contentType = headers[Constant.AccetpType].Trim();
                //do other check
            }
            return contentType;
        }

    }
}
