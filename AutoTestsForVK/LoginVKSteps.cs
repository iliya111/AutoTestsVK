using AutoTestsForVK.Classes;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutoTestsForVK
{
    [Binding]
    public class LoginVKSteps
    {
        [Given(@"Вводим логин и пароль ""(.*)"" ""(.*)""")]
        public void GivenВводимЛогинИПароль(string Login, string Password)
        {
            LoginPage Log = new LoginPage();
            Log.URL();
            //Thread.Sleep(2000);
            Log.Login(Login, Password);

        }


        [Then(@"Проверка выполненного логина")]
        public void ThenПроверкаВыполненногоЛогина()
        {
            
            UserPage Onl = new UserPage();
            Onl.AssertOnline();
        }
    }
}
