using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tivixlabs_test.BaseActions;
using tivixlabs_test.PageObjects;

namespace tivixlabs_test
{
    [TestClass]
    public class TestOfRentCar
    {
        private string tivixLabsPage = "http://qalab.pl.tivixlabs.com/";
        private string successPage = "http://qalab.pl.tivixlabs.com/success";

        [TestInitialize]
        public void NavigateToMainPage()
        {
            BaseClass.GoToPage(tivixLabsPage);
        }

        [TestMethod]
        public void UserShouldBeAbleToRentCar()
        {
            SearchPage.SearchCarForRent();
            SearchPage.ClickFirstRentButton();
            DetailsPage.ClickRent();
            SummaryPage.TypeUserDetails();
            SummaryPage.ClickRent();
            Assertions.AssertUserIsOnPage(successPage);
            
        }

        [TestCleanup]
        public void Close()
        {
            Thread.Sleep(8000);
            BaseClass.CloseBrowser();
        }
    }
}
