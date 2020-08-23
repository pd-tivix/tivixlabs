using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using tivixlabs_test.BaseActions;

namespace tivixlabs_test
{
    [TestClass]
    public class TestOfRentCar
    {
        string tivixLabsPage = "http://qalab.pl.tivixlabs.com/";

        [TestInitialize]
        public void NavigateToMainPage()
        {
            BaseClass.GoToPage(tivixLabsPage);
        }

        [TestMethod]
        public void UserShouldBeAbleToRentCar()
        {
            SearchPage.SearchCarForRent();
            
        }

        [TestCleanup]
        public void Close()
        {
            Thread.Sleep(16000);
            BaseClass.CloseBrowser();
        }
    }
}
