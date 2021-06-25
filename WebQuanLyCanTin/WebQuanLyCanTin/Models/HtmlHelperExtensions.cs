using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace WebQuanLyCanTin.Models
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString MoneyFormat(this HtmlHelper helper, object value)
        {
            XmlDocument html = new XmlDocument();
            XmlElement span = html.CreateElement("span");
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            span.InnerText = decimal.Parse(value.ToString()).ToString("#,###", cul.NumberFormat);
            if (string.IsNullOrEmpty(span.InnerText))
            {
                span.InnerText = "0";
            }
            html.AppendChild(span);
            return new MvcHtmlString(html.OuterXml);
        }
    }
}