using System;
using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    [FactoryPattern]
    public class FunctionalDependencyResolver : DependencyResolver
    {
        Func<object> factory;

        public FunctionalDependencyResolver(Func<object> factory)
        {
            this.factory = factory;
        }

        public object create()
        {
            return factory();
        }
    }
}