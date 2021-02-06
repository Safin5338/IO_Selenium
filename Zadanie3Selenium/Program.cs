using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadanie3Selenium
{
    class Program
    {
        public const string baseUrl = "http://localhost/wypozyczalnia_ksiazek"; 

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void init()
        {
            PropertiesCollection.driver.Navigate().GoToUrl(baseUrl);
            PropertiesCollection.driver.Manage().Window.Maximize();
        }

        [Test]
        public void RegisterTest()
        {
            MainPage page = new MainPage();
            page.btnRejestruj.Click();
            SignInPage pgSignUp = new SignInPage();
                Console.WriteLine("wejście w panel rejestracji"); Thread.Sleep(600);
            LoginPage pgLogin = pgSignUp.SignUp("nowy", "email@fake.not", "123", "321");
               Console.WriteLine("rejestracja"); Thread.Sleep(600);
            SetMethods.Click("Name", "powrot");
                Console.WriteLine("przejście do logowania"); Thread.Sleep(600);

        }

        [Test]
        public void LoggingTest()
        { 
            SetMethods.Click("PartialLinkText", "Zaloguj");
                Console.WriteLine("otworzenie strony logowania"); Thread.Sleep(600);
            LoginPage pgLogin = new LoginPage();
            pgLogin.Login("wrong", "wrong");
                Console.WriteLine("wpisanie złych danych logowania"); Thread.Sleep(600);
            MainPage pgMain = pgLogin.Login("admin", "dobrehaslo");
                Console.WriteLine("prawidłowe logowanie"); Thread.Sleep(600);
        }

        [Test]
        public void SearchTest()
        {
            SetMethods.Click("PartialLinkText", "Zaloguj");
            LoginPage pgLogin = new LoginPage();
            MainPage pgMain = pgLogin.Login("admin", "dobrehaslo");
            Console.WriteLine("logowanie"); Thread.Sleep(600);
            SetMethods.Click("PartialLinkText", "Spis");
            Console.WriteLine("otworzenie strony do wyszukiwania"); Thread.Sleep(600);
            SearchPage pgSearch = new SearchPage();
            pgSearch.Search("to nie książka");
            Console.WriteLine("wyszukanie błędne"); Thread.Sleep(600);
            pgSearch.Search("Cujo");
            Console.WriteLine("prawidłowe wyszukanie"); Thread.Sleep(600);

        }

        [TearDown]
        public void EndUp()
        {
            Thread.Sleep(3000);
            PropertiesCollection.driver.Close();
        }
    }
}
