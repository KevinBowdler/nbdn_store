using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    [StratagyPattern]
    public interface FrontController
    {
        void process(Request request);
    }
}