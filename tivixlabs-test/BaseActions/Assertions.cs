using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tivixlabs_test.BaseActions
{
    class Assertions : BaseClass
    {
        public static void AssertUserIsOnPage(string expectedUrl)
        {
            string currentUrl = driver.Url;

            Assert.AreEqual(expectedUrl, currentUrl);
        }
    }
}
