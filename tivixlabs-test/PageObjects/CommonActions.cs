using OpenQA.Selenium;
using tivixlabs_test.BaseActions;

namespace tivixlabs_test.PageObjects
{
    class CommonActions : BaseClass
    {
        private static By rentButton = By.ClassName("btn-primary");

        public static void ClickRent()
        {
            ClickElement(rentButton);
        }
    }
}
