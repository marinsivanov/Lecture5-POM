using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Homework.Pages
{
    public partial class HomePage
    {
        public void AssertErrorMessage(string expected)
        {
            var emailText = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//form[@id='account-creation_form']//input[@id='email']")));
            var text = emailText.GetAttribute("value");

            Assert.AreEqual(expected, text);
        }
    }
}
