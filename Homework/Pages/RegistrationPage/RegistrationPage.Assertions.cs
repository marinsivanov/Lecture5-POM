using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class RegistrationPage
    {
        public void AssertErrorMessage(string expected)
        {
            var lineToBeAsserted = Driver.FindElement(By.XPath(@"//*[@id='center_column']/div/ol/li"));
            var textToBeAsserted = lineToBeAsserted.Text;
            Assert.AreEqual(expected, textToBeAsserted);
        }
        ////*[@id="center_column"]/div/p
        public void AssertTwoErrorMessages(string expected)
        {
        var lineToBeAsserted = Driver.FindElement(By.XPath(@"//*[@id='center_column']/div/p"));
        var textToBeAsserted = lineToBeAsserted.Text;
        Assert.AreEqual(expected, textToBeAsserted);
        }
}
}
