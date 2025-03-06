using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace WebTestExploration
{
    public class Tests
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            IWebElement CheckInput;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://admlucid.com");
            CheckInput = driver.FindElement(By.LinkText("Login"));
            wait.Until(ExpectedConditions.UrlToBe("https://admlucid.com/"));
            CheckInput.Click();
            wait.Until(ExpectedConditions.UrlToBe("https://admlucid.com/Identity/Account/Login"));
            //wait.Until(d => d.Url == "https://admlucid.com/Identity/Account/Login");
            //Assert.That(d.Url.Displayed, Is.True);
            Assert.That(driver.Url, Is.EqualTo("https://admlucid.com/Identity/Account/Login"));
            //Assert.That(driver.Url, Is.EqualTo("https://admlucid.com/"));
            //Assert.Pass();
           
        }

        [TearDown]
        public void teardown() { driver.Quit(); }
    }
}