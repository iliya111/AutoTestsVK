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
        [FindsBy(How = How.XPath, Using = "//*[text()='Сообщения']")]
        public IWebElement Online { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='im_dialogs_search']")]
        public IWebElement Friend { get; set; }
        public void Search(string Name)
        {
            Friend.SendKeys(Name);
        }


        [FindsBy(How = How.XPath, Using = "(//div[@class='nim-dialog--name'])[1]")]
        public IWebElement Dialog { get; set; }
        public object Name { get; internal set; }
        public void OpenDialog()
        {
            Dialog.Click();
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='im_editable im-chat-input--text _im_text']")]
        public IWebElement CMC { get; set; }
        public void GoCMC(string CmC)
        {
            CMC.SendKeys(CmC);
        }

        [FindsBy(How = How.XPath, Using = "(//button[@class='im-send-btn im-chat-input--send _im_send im-send-btn_send'])")]
        public IWebElement itog { get; set; }
        public void Itog()
        {
            itog.Click();
        }

    }
}
