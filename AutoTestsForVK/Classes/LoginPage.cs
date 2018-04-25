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
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='dark'][@id='quick_email']")]
        public IWebElement EnterLogin { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@name='pass']")]
        public IWebElement EnterPassword { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'quick_login_button')]")]
        public IWebElement EnterInput { get; set; }

        public void Login(string Login, string Password)
        {
            EnterLogin.SendKeys(Login);
            EnterPassword.SendKeys(Password);
            EnterInput.Click();
        }

        public void URL()
        {
         PropertiesCollection.driver.Navigate().GoToUrl("https://vk.com/login?act=mobile&hash=f25c2f3f978dad3bd092a65b7d43");
        }

    }
}
