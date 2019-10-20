using Homework.Pages;
using NUnit.Framework;

namespace Homework
{
    [TestFixture]
    [Category("2. QA Automation")]
    public class SoftuniNavTest : BaseTest
    {
        private LoginPage _loginPage;
        private SoftuniNav _softuniNav;

        [SetUp]
        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _softuniNav = new SoftuniNav(Driver);
        }
        [Test]
        public void NavigateToQACourse()
        {
            _softuniNav.NavigateToSoftuniPage(_loginPage);

            _softuniNav.AssertHeaderText("QA Automation - септември 2019");

        }
    }
}
