using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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

        public static void TypeDataToField(By element, string text)
        {
            driver.FindElement((element)).SendKeys(text);
        }

        public static void ClickElement(By element)
        {
            driver.FindElement((element)).Click();
        }
    }
}
