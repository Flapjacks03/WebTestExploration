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
            Thread.Sleep(2000);

            // Login button
            IWebElement loginButton = wait.Until(driver => driver.FindElement(By.Id("login-button")));
            loginButton.Click();
            Thread.Sleep(2000);  

            // Add to cart button
            IWebElement addToCartButton = wait.Until(driver => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")));
            addToCartButton.Click();
            Thread.Sleep(2000);

            // Cart button
            IWebElement cartButton = wait.Until(driver => driver.FindElement(By.Id("shopping_cart_container")));
            cartButton.Click();
            Thread.Sleep(2000);

            // Checkout button
            IWebElement checkoutButton = wait.Until(driver => driver.FindElement(By.Id("checkout")));
            checkoutButton.Click();
            Thread.Sleep(2000);

            // First name box element
            IWebElement firstName = wait.Until(driver => driver.FindElement(By.Id("first-name")));
            // Input search term and press Enter
            firstName.SendKeys("Burat");
            Thread.Sleep(2000);

            // Last name box element
            IWebElement lastName = wait.Until(driver => driver.FindElement(By.Id("last-name")));
            // Input search term and press Enter
            lastName.SendKeys("Silog");
            Thread.Sleep(2000);

            // Zip code box element
            IWebElement zipCode = wait.Until(driver => driver.FindElement(By.Id("postal-code")));
            // Input search term and press Enter
            zipCode.SendKeys("696969");
            Thread.Sleep(2000);

            // Continue button
            IWebElement continueButton = wait.Until(driver => driver.FindElement(By.Id("continue")));
            continueButton.Click();
            Thread.Sleep(2000);

            // Finish button
            IWebElement finishButton = wait.Until(driver => driver.FindElement(By.Id("finish")));
            finishButton.Click();
            Thread.Sleep(2000);

            // Back home button
            IWebElement backHomeButton = wait.Until(driver => driver.FindElement(By.Id("back-to-products")));
            backHomeButton.Click();
            Thread.Sleep(2000);

            // Logout button
            IWebElement logoutButton = wait.Until(driver => driver.FindElement(By.Id("react-burger-menu-btn")));
            logoutButton.Click();
            Thread.Sleep(2000);

            // Logout button
            IWebElement logoutButton2 = wait.Until(driver => driver.FindElement(By.Id("logout_sidebar_link")));
            logoutButton2.Click();
            Thread.Sleep(2000);

        }

        [TearDown]
        public void teardown() { driver.Quit(); }
    }
}