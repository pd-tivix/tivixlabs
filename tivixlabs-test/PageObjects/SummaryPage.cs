using OpenQA.Selenium;
using tivixlabs_test.BaseActions;

namespace tivixlabs_test.PageObjects
{
    class SummaryPage : BaseClass
    {
        private static By name = By.Id("name");
        private static By lastName = By.Id("last_name");
        private static By cardNumber = By.Id("card_number");
        private static By email = By.Id("email");
        
        public static void TypeValidUserDetails()
        {
            TypeDataToField(name, "John");
            TypeDataToField(lastName, "Doe");
            TypeDataToField(cardNumber, "123456");
            TypeDataToField(email, "test@gmail.com");
        }
    }
}
