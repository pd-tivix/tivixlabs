using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using tivixlabs_test.BaseActions;

namespace tivixlabs_test
{
    [TestClass]
    public class TestOfRentCar
    {
        //ChromeDriver driver = new ChromeDriver();

        string tivixLabsPage = "http://qalab.pl.tivixlabs.com/";

        [TestInitialize]
        public void NavigateToMainPage()
        {
            BaseClass.GoToPage(tivixLabsPage);
        }

        [TestMethod]
        public void UserShouldBeAbleToRentCar()
        {
            SearchPage.SelectValidMandatoryData();
        }

        [TestCleanup]
        public void Close()
        {
            BaseClass.CloseBrowser();
        }
    }
}
