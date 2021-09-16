using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BaseWPF.Helpers
{
    public static class ExtensionHelper
    {
        public static string ToStringValue(this Enum en)
        {
            var type = en.GetType();
            var memInfo = type.GetMember(en.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            var stringValue = ((DescriptionAttribute)attributes[0]).Description;
            return stringValue;
        }
    }
}
