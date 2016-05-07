namespace Owen.Site.Services.Common
{
    /// <summary>
    /// 可以处理异常，运行前运行后的相关操作
    /// </summary>
    public abstract class BaseService<T> : ServiceStack.Service
    {
        public object Post(T req)
        {
            return OnPost(req);
        }

        public object Get(T req)
        {
            return OnGet(req);
        }

        public object Put(T req)
        {
            return OnPut(req);
        }

        public object Delete(T req)
        {
            return OnDelete(req);
        }

        public virtual object OnGet(T req)
        {
            return null;
        }

        public virtual object OnPost(T req)
        {
            return null;
        }

        public virtual object OnPut(T req)
        {
            return null;
        }

        public virtual object OnDelete(T req)
        {
            return null;
        }
    }
}
