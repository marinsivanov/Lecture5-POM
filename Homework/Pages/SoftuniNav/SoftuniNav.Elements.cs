using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class SoftuniNav : BasePage
    {
        public SoftuniNav(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement Courses => Driver.FindElement(By.XPath(@"//*[@id='header-nav']/div[1]/ul/li[2]/a/span"));
        public IWebElement QaCourseLink => Driver.FindElement(By.LinkText("QA Automation - септември 2019"));
        public IWebElement Header => Driver.FindElement(By.XPath(@"/html/body/div[2]/header/h1"));
    }
}