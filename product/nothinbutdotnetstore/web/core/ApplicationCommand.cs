using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    [CommandPattern]
    public interface ApplicationCommand
    {
        void process(Request request);
    }
}