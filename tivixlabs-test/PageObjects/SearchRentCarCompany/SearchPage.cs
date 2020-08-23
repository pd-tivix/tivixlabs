using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tivixlabs_test.BaseActions;

namespace tivixlabs_test
{
    class SearchPage : BaseClass
    {
        IWebDriver _driver;
        private static IWebElement country = driver.FindElement()By.Id("country");

        public SearchPage()
        {
            _driver = driver;
        }

        public static void SelectValidMandatoryData()
        {
            BaseClass.SelectFromDropDown(country, "");
        }
    }
}
