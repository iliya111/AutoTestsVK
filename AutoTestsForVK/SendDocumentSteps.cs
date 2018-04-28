using AutoTestsForVK.Classes;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutoTestsForVK
{
    [Binding]
    public class SendDocumentSteps
    {
        [When(@"Нажимаем на кнопку прикрепить документ")]
        public void WhenНажимаемНаКнопкуПрикрепитьДокумент()
        {
            SendDocument Doc = new SendDocument();
            Doc.Docum.Click();
        }
        [When(@"Нажимаем на кнопку Документ")]
        public void WhenНажимаемНаКнопкуДокумент()
        {
            SendDocument affix = new SendDocument();
            affix.docaffix();
            Thread.Sleep(5000);
        }

        [When(@"Прикрепляем документ")]
        public void WhenПрикрепляемДокумент()
        {
            SendDocument nearli = new SendDocument();
            nearli.AffixD();
            Thread.Sleep(5000);
        }
        
        [When(@"Отправляем")]
        public void WhenОтправляем()
        {
            SendDocument ITOG = new SendDocument();
            ITOG.Senddocument();
            Thread.Sleep(6000);
        }
        
        [Then(@"Проверяем отправку документа")]
        public void ThenПроверяемОтправкуДокумента()
        {
           
        }
    }
}
