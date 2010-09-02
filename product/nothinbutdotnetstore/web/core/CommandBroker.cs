using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    [RegistryPattern]
    public interface CommandBroker
    {
        RequestCommand get_command_that_can_process(Request request);
    }
}