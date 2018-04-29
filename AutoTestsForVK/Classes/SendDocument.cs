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
    class SendDocument
    {
        public SendDocument()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Кнопка для выбора инструмента
        [FindsBy(How = How.XPath, Using = "(//span[@class='ms_item_more_label'])")]
        public IWebElement Docum { get; set; }

        //Кнопка для перехода к документам
        [FindsBy(How = How.XPath, Using = "//a[@class='ms_item ms_item_doc _type_doc']")]
        public IWebElement DocAffix { get; set; }
        public object ame { get; internal set; }

        public void docaffix()
        {
            DocAffix.Click();
        }

        //Кнопка прикрепить
        [FindsBy(How = How.XPath, Using = "(//span[@class='docs_choose_attach _docs_choose_attach'])[1]")]
        public IWebElement AffixDocument { get; set; }

        public void AffixD()
        {
            AffixDocument.Click();
        }

        //Кнопка отправить сообщение
        [FindsBy(How = How.XPath, Using = "(//button[@class='im-send-btn im-chat-input--send _im_send im-send-btn_send'])")]
        public IWebElement senddocument { get; set; }
        public void Senddocument()
        {
            senddocument.Click();
        }
    }
}
