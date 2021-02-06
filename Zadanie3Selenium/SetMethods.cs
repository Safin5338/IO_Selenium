using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;
namespace Zadanie3Selenium
{
    class SetMethods
    {
            public static void InputTxt(string elementType, string element, string value)
            {
                if (elementType == "Id")
                    PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
                if (elementType == "Name")
                    PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            

            }
            public static void Click(string elementType, string element)
            {
                if (elementType == "PartialLinkText")
                    PropertiesCollection.driver.FindElement(By.PartialLinkText(element)).Click();
                if (elementType == "Id")
                    PropertiesCollection.driver.FindElement(By.Id(element)).Click();
                if (elementType == "Name")
                    PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            }
        //public static void SelectDropDown(IWebPropertiesCollection.driver PropertiesCollection.driver, string element, string elementtype, string value)
        //{
        //    if (elementtype == "Id")
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        //    if (elementtype == "Name")
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        //}
    }
}
