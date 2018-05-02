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
            GoToMessage go = new GoToMessage();
            Thread.Sleep(2000);
            go.OpenDialog();
            
        }
        
        [When(@"Написать сообщение ""(.*)""")]
        public void WhenНаписатьСообщение(string CmC)
        {
            GoToMessage goTo = new GoToMessage();
            goTo.GoCMC(CmC);
        }
        
        [When(@"Отправить сообщение")]
        public void WhenОтправитьСообщение()
        {
            Thread.Sleep(5000);
            GoToMessage message = new GoToMessage();
            message.Itog();
            Thread.Sleep(2000);
        }
       
    }
}
