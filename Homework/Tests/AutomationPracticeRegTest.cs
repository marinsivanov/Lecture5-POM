using Homework.Pages;
using NUnit.Framework;

namespace Homework
{
    [TestFixture]
    [Category("3. Automationpractice registration page")]
    public class AutomationPracticeRegTest : BaseTest
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]
        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _homePage = new HomePage(Driver);
        }
        [Test]
        public void NavigateToRegistrationForm()
        {
            _homePage.NavigateToRegPage(_loginPage);

            _homePage.AssertErrorMessage("zeustest@gmail.com");

        }
    }
}
