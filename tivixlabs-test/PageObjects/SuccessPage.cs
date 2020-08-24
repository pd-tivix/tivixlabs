using Microsoft.VisualStudio.TestTools.UnitTesting;
using tivixlabs_test.BaseActions;

namespace tivixlabs_test.PageObjects
{
    class SuccessPage : BaseClass
    {
        public static void AssertUserIsOnSuccessPage(string expectedUrl)
        {
            string currentUrl = driver.Url;

            Assert.AreEqual(expectedUrl, currentUrl);
        }
    }
}
