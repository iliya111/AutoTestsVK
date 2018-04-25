using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SenatUI.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            PropertiesCollection.driver = new ChromeDriver();
            Console.WriteLine("Открыли браузер");
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {

                Screenshot ss = ((ITakesScreenshot)PropertiesCollection.driver).GetScreenshot();
                String scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
                String currDateTime = DateTime.UtcNow.ToString("dd-MM-yyyy HH:mm:ss");
                Console.WriteLine("Current date and time: " + currDateTime);
                Console.WriteLine("Failed scenario: " + scenarioName);
                ss.SaveAsFile("C:\\Users\\Out-velichkin-ai\\source\\repos\\SenatSolution\\SenatUI\\Screenshots\\" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + scenarioName + ".png", ScreenshotImageFormat.Png);


                PropertiesCollection.driver.Close();
            }
            PropertiesCollection.driver.Close();
            Console.WriteLine("Закрыли браузер");
        }
    }
}
