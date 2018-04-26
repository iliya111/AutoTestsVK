using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SenatUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestsForVK.Classes
{
    class GoToMessage
    {
        public GoToMessage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='im_dialogs_search']")]
        public IWebElement Friend { get; set; }

        public void Search(string Name)
        {
            Friend.SendKeys(Name);

        }
        [FindsBy(How = How.XPath, Using = "(//div[@class='nim-dialog--name'])[1]")]
        public IWebElement Dialog { get; set; }

        public void OpenDialog()
        {
            Dialog.Click();
        }
    }
}
