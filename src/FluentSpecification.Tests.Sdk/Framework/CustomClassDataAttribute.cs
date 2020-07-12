using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit.Sdk;

namespace FluentSpecification.Tests.Sdk.Framework
{
    public abstract class CustomClassDataAttribute : DataAttribute
    {
        private static readonly Dictionary<Type, object> Cache = new Dictionary<Type, object>();

        private Type _class;
        [PublicAPI] 
        public Type Class 
        { 
            get => _class;
            private set
            {
                ValidateClass(value);
                _class = value;
            }
        }

        protected CustomClassDataAttribute()
        {
        }

        protected CustomClassDataAttribute(Type @class)
        {
            Class = @class;
        }

        protected abstract void ValidateClass(Type value);

        protected T CreateInstance<T, TAttribute>(MethodInfo testMethod)
            where TAttribute : CustomClassDataAttribute
        {
            var factoryType = Class ?? GetClassDataAttribute<TAttribute>(testMethod).Class;
            return GetFactoryFromCache<T>(factoryType);
        }

        protected static TAttribute GetClassDataAttribute<TAttribute>(MethodInfo testMethod)
            where TAttribute : Attribute
        {
            if (testMethod.DeclaringType.GetTypeInfo().IsGenericType)
            {
                return testMethod
                    .DeclaringType.GetTypeInfo()
                    .GetGenericArguments().First()
                    .GetTypeInfo().GetCustomAttribute<TAttribute>(true);
            }

            return null;
        }

        protected static T GetFactoryFromCache<T>(Type factoryType)
        {
            if (!Cache.ContainsKey(factoryType))
                Cache.Add(factoryType, Activator.CreateInstance(factoryType));

            return (T)Cache[factoryType];
        }
    }
}
