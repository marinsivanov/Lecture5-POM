namespace Homework.Pages
{
    public partial class GoogleSearch
    {
        public void NavigateToSearchResult(LoginPage loginPage)
        {
            loginPage.Navigate("https://www.google.com/");
            SearchInput.SendKeys("Selenium");
            Logo.Click();
            SearchButton.Click();
            SeleniumResult.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate("https://www.google.com/");
        }
    }
}