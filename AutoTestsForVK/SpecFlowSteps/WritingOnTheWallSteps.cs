using AutoTestsForVK.Classes;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutoTestsForVK
{
    [Binding]
    public class WritingOnTheWallSteps
    {
        [When(@"Заходим друзья")]
        public void WhenЗаходимДрузья()
        {
            WritingOnTheWall FRend = new WritingOnTheWall();
            FRend.Friends.Click();
        }
        
        [When(@"Находим друга ""(.*)""")]
        public void WhenНаходимДруга(string Name)
        {
            WritingOnTheWall NameFriend = new WritingOnTheWall();
            NameFriend.SEarch(Name);
        }
        
        [When(@"Заходим на страницу")]
        public void WhenЗаходимНаСтраницу()
        {
            Thread.Sleep(3000);
            WritingOnTheWall Friend = new WritingOnTheWall();
            Friend.Avatar.Click();
        }

        [When(@"Находим и прикрепляем аудиозапись на стену ""(.*)""")]
        public void WhenНаходимИПрикрепляемАудиозаписьНаСтену(string tracK)
        {
            WritingOnTheWall WALL = new WritingOnTheWall();
            WALL.Wall.Click();
            WALL.Music.Click();
            Thread.Sleep(3000);
            WALL.Track(tracK);
        }

        [When(@"Отправить сообщение на стену")]
        public void WhenОтправитьСообщениеНаСтену()
        {
            Thread.Sleep(3000);
            WritingOnTheWall AFFIX = new WritingOnTheWall();
            AFFIX.Affix.Click();
            AFFIX.Send.Click();
        }

        [When(@"Ставим лайк")]
        public void WhenСтавимЛайк()
        {
            Thread.Sleep(3000);
            WritingOnTheWall LIKE = new WritingOnTheWall();
            LIKE.Like.Click();
            Thread.Sleep(6000);
        }
 
    }
}
