using ServiceStack.Configuration;
using System;
using Autofac;

namespace Owen.Site.Core.Common
{
    public class InterfaceAdapter : IContainerAdapter
    {
        public T TryResolve<T>()
        {
            return AutofacManager.Current.Container.Resolve<T>();
        }

        public T Resolve<T>()
        {
            return AutofacManager.Current.Container.Resolve<T>();
        }
    }
}
