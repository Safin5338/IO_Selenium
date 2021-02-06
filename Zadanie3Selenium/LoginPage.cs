using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Zadanie3Selenium
{
    class LoginPage
    {

            public LoginPage()
            {
                PageFactory.InitElements(PropertiesCollection.driver, this);
            }

            [FindsBy(How = How.Name, Using = "login")]
            public IWebElement txtLoginInput { get; set; }

            [FindsBy(How = How.Name, Using = "haslo")]
            public IWebElement txtPasswdInput { get; set; }

            [FindsBy(How = How.Name, Using = "logowanie")]
            public IWebElement btnZaloguj { get; set; }

        public MainPage Login(string login, string pass)
        {
            txtLoginInput.SendKeys(login);
            txtPasswdInput.SendKeys(pass);
            btnZaloguj.Click();

            return new MainPage();
        }
    }
}

