using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tivixlabs_test.BaseActions
{
    public class BaseClass
    {
        public static IWebDriver driver = new ChromeDriver();

        public static void GoToPage(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseBrowser()
        {
            driver.Dispose();
        }

        public static void SelectFromDropDown(IWebElement element, string text)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text);
        }
    }
}
