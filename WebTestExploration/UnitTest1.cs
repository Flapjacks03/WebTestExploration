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

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Wait until the search box is present
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            // Find the username box element
            IWebElement searchBox = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("user-name")));

            // Input search term and press Enter
            searchBox.SendKeys("standard_user");
           
        }

        [TearDown]
        public void teardown() { driver.Quit(); }
    }
}