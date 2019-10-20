using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Homework
{
    [TestFixture]
    [Category("4. Automationpractice Registration negative tests")]
    public class AutomationPracticeNegativeTests : BaseTest
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;

        [SetUp]
        public void ClassInit()
        {

            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);

            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void FillRegistrationFormNoFirstName()
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("firstname is required.");
        }
        [Test]
        public void FillRegistrationFormWrongPostcode()
        {
            _user.PostCode = "4324343";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("The Zip/Postal code you've entered is invalid. It must follow this format: 00000");
        }
        [Test]
        public void FillRegistrationFormNoPhone()
        {
            _user.Phone = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("You must register at least one phone number.");
        }
        [Test]
        public void FillRegistrationFormNoPassword()
        {
            _user.Password = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("passwd is required.");
        }
        [Test]
        public void FillRegistrationFormNoLastNameAndPassword()
        {
            _user.Password = "";
            _user.LastName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertTwoErrorMessages("There are 2 errors");
        }
    }
}
