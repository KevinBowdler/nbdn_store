using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public interface DependencyResolver
    {
        object create();
    }
}