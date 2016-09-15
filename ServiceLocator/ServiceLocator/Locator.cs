using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public sealed class Locator
    {
        static readonly Lazy<Locator> instance = new Lazy<Locator>(() => new Locator());
        readonly Dictionary<Type, Lazy<object>> registeredServices = new Dictionary<Type, Lazy<object>>();

        public static Locator Instance
        {
            get { return instance.Value; }
        }

        public void Add<TContract, TService>() where TService : new()
        {
            this.registeredServices[typeof(TContract)] =
                new Lazy<object>(() => Activator.CreateInstance(typeof(TService)));
        }

        public T Resolve<T>()
        {
            Lazy<object> service;
            if (registeredServices.TryGetValue(typeof(T), out service))
            {
                return (T)service.Value;
            }

            throw new Exception("No service found for " + typeof(T).Name);
        }
    }
}
