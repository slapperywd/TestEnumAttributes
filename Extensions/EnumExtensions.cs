using System;
using System.Linq;
using TestEnumAttributes.Attributes;
using TestEnumAttributes.Utils;

namespace TestEnumAttributes.Extensions
{
    public static class EnumExtensions
    {
        public static string GetXpathValue(this Enum enumeration)
        {
            return SafeExecutor.Execute(
                    () => enumeration.GetType()
                        .GetMember(enumeration.ToString()).First()
                        .GetCustomAttributes(typeof(XpathAttribute), false)
                        .Select(ob => (XpathAttribute) ob).First()
                        .Selector
                    );
        }
    }
}