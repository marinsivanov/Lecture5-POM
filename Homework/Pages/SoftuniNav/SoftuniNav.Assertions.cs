using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Homework.Pages
{
    public partial class SoftuniNav
    {
        public void AssertHeaderText(string expected)
        {
            var actualHeader = Header.Text;

            Assert.AreEqual(expected, actualHeader);
        }
    }
}