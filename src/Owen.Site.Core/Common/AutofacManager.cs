using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace Owen.Site.Core.Common
{
    public class AutofacManager
    {
        public void Init()
        {
            var assemblyStrList = new List<string>{
                "",
                "",
                "",
                ""
            };
            /*
            Assembly.LoadFile()
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(assemblies)
            .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
            .AsImplementedInterfaces().InstancePerLifetimeScope();//InstancePerLifetimeScope 保证对象生命周期基于请求
                    IContainer container = builder.Build();
                    DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
             */
        }
    }
}
