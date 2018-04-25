using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenatUI
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssSelector,
        ClassName,
        Xpath
    }

    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
