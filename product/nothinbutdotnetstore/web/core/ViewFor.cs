using System.Web;
using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    [StratagyPattern]
    public interface ViewFor<Model> : IHttpHandler
    {
        Model model { get; set; }
    }
}