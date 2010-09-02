using System;
using System.Web;
using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core.stubs
{
    [FactoryPattern]
    public class StubRequestFactory : RequestFactory
    {
        public Request create_from(HttpContext context)
        {
            return new StubRequest();
        }

        class StubRequest : Request
        {
            public InputModel map<InputModel>()
            {
                throw new NotImplementedException();
            }
        }
    }
}