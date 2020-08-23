using OpenQA.Selenium;
using System;
using tivixlabs_test.BaseActions;

namespace tivixlabs_test
{
    class SearchPage : BaseClass
    {
        private static IWebElement country = driver.FindElement(By.Id("country"));
        private static IWebElement city = driver.FindElement(By.Id("city"));
        private static By pickUpDate = By.Name("pickup");
        private static By dropOffDate = By.Name("dropoff");
        private static By searchButton = By.XPath("//button[@type=\'submit\']");

        private static DateTime seven = DateTime.Now.AddDays(7);

        private static string todayDate = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
        private static string todayPlusSeven = seven.Month + "/" + seven.Day + "/" + seven.Year.ToString();


        public static void SearchCarForRent()
        {
            SelectFromDropDown(country, "Poland");
            SelectFromDropDown(city, "Wroclaw");
            TypeDataToField(pickUpDate, todayDate);
            TypeDataToField(dropOffDate, todayPlusSeven);
            ClickElement(searchButton);
        }
    }
}
