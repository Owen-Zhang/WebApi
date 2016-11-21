using ServiceStack.Configuration;
using System;
using Autofac;

namespace Owen.Site.Core.Common
{
    public class InterfaceAdapter : IContainerAdapter
    {
        public T TryResolve<T>()
        {
            T result;
            if (!AutofacManager.Current.Container.TryResolve<T>(out result))
                result = default(T);

            return result;
        }

        public T Resolve<T>()
        {
            return AutofacManager.Current.Container.Resolve<T>();
        }
    }
}
