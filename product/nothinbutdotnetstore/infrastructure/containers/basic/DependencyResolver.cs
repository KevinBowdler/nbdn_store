using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    [StratagyPattern]
    public interface DependencyResolver
    {
        object create();
    }
}