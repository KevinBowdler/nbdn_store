using System;

namespace nothinbutdotnetstore.catagorisations
{
    public class  ConcreteImplementation : Attribute
    {
        private Attribute attribute;

        public ConcreteImplementation(Attribute attribute)
        {
            this.attribute = attribute;
        }
    }
}