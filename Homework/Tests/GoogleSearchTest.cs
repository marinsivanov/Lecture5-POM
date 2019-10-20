using Homework.Pages;
using NUnit.Framework;

namespace Homework
{
    [TestFixture]
    [Category("1. Google Search")]
    public class GoogleSearchTest : BaseTest
    {
        private LoginPage _loginPage;
        private GoogleSearch _googleSearch;

        [SetUp]
        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _googleSearch = new GoogleSearch(Driver);
        }
        [Test]
        public void NavigateToGoogleSearchResult()
        {
            _googleSearch.NavigateToSearchResult(_loginPage);

            _googleSearch.AssertPageTitle("Selenium - Web Browser Automation");

        }
    }
}
