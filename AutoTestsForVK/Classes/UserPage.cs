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
        public UserPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Поле сообщения
        [FindsBy(How = How.XPath, Using = "//*[text()='Сообщения']")]
        public IWebElement Online { get; set; }

        //Поле поиска друга
        [FindsBy(How = How.XPath, Using = "//input[@id='im_dialogs_search']")]
        public IWebElement Search { get; set; }

        public void AssertOnline()
        {
            Thread.Sleep(5000); 
            Assert.IsTrue(Online.Displayed);
        }


    }
}    
