namespace Homework.Pages
{
    public partial class SoftuniNav
    {
        public void NavigateToSoftuniPage(LoginPage loginPage)
        {
            loginPage.Navigate("https://softuni.bg/");
            Courses.Click();
            QaCourseLink.Click();
        }
    }
}
