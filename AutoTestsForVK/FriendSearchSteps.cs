using AutoTestsForVK.Classes;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutoTestsForVK
{
    [Binding]
    public class FriendSearchSteps
    {
        [When(@"Заходим в Сообщения")]
        public void WhenЗаходимВСообщения()
        {
            GoToMessage cmc = new  GoToMessage();
            cmc.Online.Click();
        }

        [When(@"В строке Поиск находим ""(.*)""")]
        public void WhenВСтрокеПоискНаходим(string Name)
        {
           GoToMessage WeFind = new GoToMessage();
            WeFind.Search(Name);
        }
        
        [When(@"Нажать на аватарку")]
        public void WhenНажатьНаАватарку()
        {
            //Thread.Sleep(6000);
            GoToMessage go = new GoToMessage();
            go.OpenDialog();
            Thread.Sleep(6000);
        }
        
        [When(@"Написать сообщение ""(.*)""")]
        public void WhenНаписатьСообщение(string CmC)
        {
            GoToMessage goTo = new GoToMessage();
            goTo.GoCMC(CmC);
            //Thread.Sleep(8000);
        }
        
        [When(@"Отправить сообщение")]
        public void WhenОтправитьСообщение()
        {
            Thread.Sleep(15000);
            GoToMessage message = new GoToMessage();
            message.Itog();
            Thread.Sleep(5000);
        }
        
        [Then(@"Проверка отправки сообщения")]
        public void ThenПроверкаОтправкиСообщения()
        {
            GoToMessage AssertGoToMessage = new GoToMessage();
            
        }
    }
}
