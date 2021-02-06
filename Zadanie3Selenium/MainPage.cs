using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Zadanie3Selenium
{
    class MainPage
    {
       [FindsBy(How = How.PartialLinkText, Using = "główna")]
       public IWebElement btnGlowna { get; set; }
       [FindsBy(How=How.PartialLinkText, Using = "Zaloguj")] 
       public IWebElement btnZaloguj { get; set; }
       [FindsBy(How = How.PartialLinkText, Using = "Zarejestruj")]
       public IWebElement btnRejestruj { get; set; }

        public MainPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
    }
}
