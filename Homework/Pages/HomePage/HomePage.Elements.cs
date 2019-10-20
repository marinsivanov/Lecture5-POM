
using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement SignInButton => Driver.FindElement(By.PartialLinkText(@"Sign in"));
        public IWebElement EmailInput => Driver.FindElement(By.Id("email_create"));
        public IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
    }
}
