using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tivixlabs_test.BaseActions;
using OpenQA.Selenium;

namespace tivixlabs_test.PageObjects
{
    class DetailsPage : BaseClass
    {
        private static By rentButton = By.ClassName("btn btn-primary");

        public static void ClickRent()
        {
            ClickElement(rentButton);
        }
    }


}
