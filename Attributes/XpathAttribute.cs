using System;

namespace TestEnumAttributes.Attributes
{
    public class XpathAttribute : Attribute
    {
        public string Selector { get; set; }

        public XpathAttribute(string xPathSelector)
        {
            this.Selector = xPathSelector;
        }
    }
}
