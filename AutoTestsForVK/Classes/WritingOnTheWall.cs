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
    class WritingOnTheWall
    {
        public WritingOnTheWall()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        //Поле Друзья
        [FindsBy(How = How.XPath, Using = "(//span[contains (text(),'Друзья')])[1]")]
        public IWebElement Friends { get; set; }

        //Поле поиска друга
        [FindsBy(How = How.XPath, Using = "//input[@id='s_search']")]
        public IWebElement Search { get; set; }

        public void SEarch(string Name)
        {
            Search.SendKeys(Name);
        }
        //Поле найденного друга
        [FindsBy(How = How.XPath, Using = "(//img[@data-alt='Александра Дмитриевна'])[1]")]
        public IWebElement Avatar { get; set; }

        //Поле записи на стену
        [FindsBy(How = How.XPath, Using = "//div[@class='submit_post_field dark submit_post_inited']")]
        public IWebElement Wall { get; set; }
     
        //Кнопка добавления аудиозаписи
        [FindsBy(How = How.XPath, Using = "//a[@class='ms_item ms_item_audio _type_audio']")]
        public IWebElement Music { get; set; }
      
        //Поле поиска трека
        [FindsBy(How = How.XPath, Using = "(//input[@class='ui_search_field _field'])[1]")]
        public IWebElement SearchTrack { get; set; }

        public void Track(string track)
        {
            SearchTrack.SendKeys(track);
        }

        //Кнопка прикрепить
        [FindsBy(How = How.XPath, Using = "(//div[@class='ape_attach'])[1]")]
        public IWebElement Affix { get; set; }

        //Кнопка отправить 
        [FindsBy(How = How.XPath, Using = "//button[@id='send_post']")]
        public IWebElement Send { get; set; }

        //Кнопка лайка
        [FindsBy(How = How.XPath, Using = "(//i)[1]")]
        public IWebElement Like { get; set; }

       

    }
}
