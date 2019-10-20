
namespace Homework.Pages
{
    public partial class HomePage
    {
       public void NavigateToRegPage(LoginPage loginPage)
        {
            loginPage.Navigate("http://automationpractice.com/index.php");
            SignInButton.Click();
            EmailInput.SendKeys("zeustest@gmail.com");
            CreateAccountButton.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate("http://automationpractice.com/index.php");
        }
    }
}
