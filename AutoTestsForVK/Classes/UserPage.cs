using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SenatUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTestsForVK.Classes
{
    class UserPage
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Сообщения')]")]
        public IWebElement Online { get; set; }

        public void AssertOnline()
        {
         
           
            //Thread.Sleep(10000);
            //Assert.IsTrue(Online.Displayed);
        }


    }
}    
