using System;
using System.Web;

namespace nothinbutdotnetstore.web.core
{
    public interface RequestFactory
    {
        Request create_from(HttpContext context);
    }
}