using System;
using nothinbutdotnetstore.catagorisations;

namespace nothinbutdotnetstore.web.core
{
    [CommandPattern]
    public class MissingRequestCommand : RequestCommand
    {
        public void process(Request request)
        {
            throw new NotImplementedException();
        }

        public bool can_handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}