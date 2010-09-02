using System;
using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.infrastructure.containers
{
    [StratagyPattern]
    public interface Container
    {
        Dependency an<Dependency>();
        object an(Type dependency);
    }
}