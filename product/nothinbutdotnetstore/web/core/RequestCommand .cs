using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    [CommandPattern]
    public interface RequestCommand : ApplicationCommand
    {
        bool can_handle(Request request);
    }
}