using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Zadanie3Selenium
{
    class SearchPage
    {
        public SearchPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "search")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.Name, Using = "wyszukane")]
        public IWebElement txtSearchInput { get; set; }

        public void Search(string input)
        {
            txtSearchInput.SendKeys(input);
            btnSearch.Click();
        }
    }

    

}
