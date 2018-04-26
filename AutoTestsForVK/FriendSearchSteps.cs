using AutoTestsForVK.Classes;
using System;
using System.Threading;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutoTestsForVK
{
    [Binding]
    public class FriendSearchSteps
    {
        public object Tread { get; private set; }

        [When(@"Переходим в Сообщения")]
        public void WhenПереходимВСообщения()
        {
            UserPage Message = new UserPage();
            Message.Online.Click();
        }
        
        [When(@"В строке Поиск находим ""(.*)""")]
        public void WhenВСтрокеПоискНаходим(string Name)
        {
            GoToMessage search = new GoToMessage();
            search.Search(Name);

        }
        
        [When(@"Нажать на аватарку")]
        public void WhenНажатьНаАватарку()
        {
            
            GoToMessage OpenChat = new GoToMessage();
            OpenChat.OpenDialog();
            Thread.Sleep(5000);
        }

        [When(@"Написать сообщение ""(.*)""")]
        public void WhenНаписатьСообщение(string SMS)
        {
            
        }


        [When(@"Отправить сообщение")]
        public void WhenОтправитьСообщение()
        {
         
        }
        
        [Then(@"Проверка отправки сообщения")]
        public void ThenПроверкаОтправкиСообщения()
        {
         
        }
    }
}
