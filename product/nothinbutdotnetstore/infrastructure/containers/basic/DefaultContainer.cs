using System;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public class DefaultContainer : Container
    {
        private ResolverRegistry resolver_registry;

        public DefaultContainer(ResolverRegistry resolver_registry)
        {
            this.resolver_registry = resolver_registry;
        }

        public Dependency an<Dependency>()
        {
            return (Dependency) resolver_registry.get_resolver_to_create(typeof (Dependency)).create();
        }
    }
}