using Microsoft.VisualStudio.TestTools.UnitTesting;
using tivixlabs_test.BaseActions;
using tivixlabs_test.PageObjects;

namespace tivixlabs_test
{
    [TestClass]
    public class TestOfRentCar
    {
        private const string tivixLabsPage = "http://qalab.pl.tivixlabs.com/";
        private const string successPage = "http://qalab.pl.tivixlabs.com/success";

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
            CommonActions.ClickRent();
            SummaryPage.TypeValidUserDetails();
            CommonActions.ClickRent();
            SuccessPage.AssertUserIsOnSuccessPage(successPage);
        }

        [TestCleanup]
        public void Close()
        {
            BaseClass.CloseBrowser();
        }
    }
}
