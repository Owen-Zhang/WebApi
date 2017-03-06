using System;
using System.Configuration;
using System.Reflection;

namespace Owen.Site.Core.Common
{
    public class ConfigurationService
    {
        public static T GetAppSetting<T>(string key)
        {
            var result = ConfigurationManager.AppSettings[key];

            if (result == null)
                throw new Exception(string.Format("key:[{0}] didn't exists in appsettings", key));

            return GetValue<T>(key, result);
        }

        /// <summary>
        /// 没有处理异常
        /// </summary>
        private static T GetValue<T>(string key, object value)
        {
            if (string.IsNullOrEmpty(key)) return default(T);
            Type tp = typeof(T);

            if (tp.IsGenericType)
                tp = tp.GetGenericArguments()[0];

            if (string.Equals(tp.Name, "string", StringComparison.OrdinalIgnoreCase))
                return (T)value;

            //在此可以使用ConcurrentDictionary来缓存MethodInfo
            var tryParse = tp.GetMethod(
                                "TryParse",
                                BindingFlags.Public | BindingFlags.Static,
                                Type.DefaultBinder,
                                new Type[] { typeof(string), tp.MakeByRefType() },
                //new ParameterModifier[] { new ParameterModifier(2)});
                                null);
            var parameters = new object[] { value, Activator.CreateInstance(tp) };
            var result = (bool)tryParse.Invoke(null, parameters);

            if (result)
                return (T)parameters[1];

            return default(T);
        }
    }
}
