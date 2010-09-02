using System.Web;
using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    public interface RequestFactory
    {
        Request create_from(HttpContext context);
    }
}