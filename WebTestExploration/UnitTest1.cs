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
            IWebElement userName = wait.Until(driver => driver.FindElement(By.Id("user-name")));

            // Input search term and press Enter
            userName.SendKeys("standard_user");
            Thread.Sleep(3000);

            // Find the password box element
            IWebElement password = wait.Until(driver => driver.FindElement(By.Id("password")));

            // Input search term and press Enter
            password.SendKeys("secret_sauce");
            Thread.Sleep(3000);

            // Login button
            IWebElement loginButton = wait.Until(driver => driver.FindElement(By.Id("login-button")));
            loginButton.Click();
            Thread.Sleep(3000);
            

        }

        [TearDown]
        public void teardown() { driver.Quit(); }
    }
}