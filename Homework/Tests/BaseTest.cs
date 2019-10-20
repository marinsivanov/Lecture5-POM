using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace Homework

{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void InitializeTests()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

    //        ChromeOptions options = new ChromeOptions();

    //        options.PlatformName = "windows";
    //        options.BrowserVersion = "77.0";

    //        Driver = new RemoteWebDriver(new Uri("http://192.168.0.101:4444/wd/hub"),options.ToCapabilities(), TimeSpan.FromSeconds(10));
    //        Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
