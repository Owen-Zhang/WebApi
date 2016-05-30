using System.IO;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
namespace Owen.Site.Core.Common
{
    public class AutofacManager
    {
        static AutofacManager manager;
        static IContainer container;

        AutofacManager()
        {    
        }

        public static AutofacManager Current {
            get
            {
                if (manager == null)
                    manager = new AutofacManager();
                return manager;
            }
        }

        public static T GetService<T>()
        {
            return Current.Container.Resolve<T>();
        }

        public IContainer Container
        {
            get
            {
                if (container == null)
                    Init();
                return container;
            }
        }

        public void Init()
        {
            var assemblyStrList = new List<string>{
                "Owen.Site.Data.Service.dll",
                "Owen.Site.Data.Service.Imp.dll",
                "Owen.Site.Main.Service.dll",
                "Owen.Site.Main.Service.Imp.dll"
            };

            List<Assembly> assemblies = new List<Assembly>();
            foreach (var item in assemblyStrList)
	        {
                assemblies.Add(
                    Assembly.LoadFile(Path.Combine(HttpContext.Current.Server.MapPath("~"), "bin", item)));
	        }
            
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(assemblies.ToArray())
                    .Where(type => typeof(IDependency).IsAssignableFrom(type) && !type.IsAbstract)
                    .AsImplementedInterfaces().InstancePerLifetimeScope();
            container = builder.Build();
            new ServiceProvider(container);
        }
    }
}
