using System.Web.UI;
using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    [StratagyPattern]
    public class DefaultViewFor<Model> : Page, ViewFor<Model>
    {
        public Model model { get; set; }
    }
}