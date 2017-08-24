using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBookkeeping.Helper
{
    public static class SetStyle
    {
        public static MvcHtmlString SetIncome(this HtmlHelper helper, string type)
        {
            if (type == "收入")
            {
                return MvcHtmlString.Create($"<font color='blue'>{type}</font>");
            }
            else
                return MvcHtmlString.Create($"<font color='red'>{type}</font>");
        }
    }
}