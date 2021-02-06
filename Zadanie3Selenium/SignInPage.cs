using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Zadanie3Selenium
{
    class SignInPage
    {
        public SignInPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement txtLoginInput { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtEmailInput { get; set; }

        [FindsBy(How = How.Name, Using = "haslo1")]
        public IWebElement txtPasswd1Input { get; set; }

        [FindsBy(How = How.Name, Using = "haslo2")]
        public IWebElement txtPasswd2Input { get; set; }

        [FindsBy(How = How.Name, Using = "rejestruj")]
        public IWebElement btnRejestruj { get; set; }

        [FindsBy(How = How.Name, Using = "powrot")]
        public IWebElement btnGoToLogin { get; set; }

        public LoginPage SignUp(string login, string email, string pass1, string pass2)
        {
            txtLoginInput.SendKeys(login);
            txtPasswd1Input.SendKeys(email);
            txtEmailInput.SendKeys(pass1);
            txtPasswd2Input.SendKeys(pass2);
            btnRejestruj.Click();

            return new LoginPage();
        }
    }
}
