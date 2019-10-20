using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Homework.Pages
{
    public partial class GoogleSearch
    {
        public void AssertPageTitle(string expected)
        {
            var actualTitle = Driver.Title;

            Assert.AreEqual(expected, actualTitle);
        }
    }
}
