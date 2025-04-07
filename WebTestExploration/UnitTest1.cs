using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.DevTools.V131.Audits;



namespace WebTestExploration
{
    public class Tests
    {

        IWebDriver driver;
        static void FreezePage(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

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
            FreezePage(1000);
        

            // Find the password box element
            IWebElement password = wait.Until(driver => driver.FindElement(By.Id("password")));

            // Input search term and press Enter
            password.SendKeys("secret_sauce");
            FreezePage(1000);

            // Login button
            IWebElement loginButton = wait.Until(driver => driver.FindElement(By.Id("login-button")));
            loginButton.Click();
            FreezePage(1000);  

            // react-burger-menu-btn button
            IWebElement menubutton = wait.Until(driver => driver.FindElement(By.Id("react-burger-menu-btn")));
            menubutton.Click();
            FreezePage(1000);

            // About button
            IWebElement aboutbutton = wait.Until(driver => driver.FindElement(By.Id("about_sidebar_link")));
            aboutbutton.Click();
            FreezePage(1000);

            // scroll down
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.End).Perform();
            FreezePage(1000);

            // highlight the text
            IWebElement text = wait.Until(driver => driver.FindElement(By.LinkText("FAQs")));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].style.backgroundColor = 'yellow';", text);
            FreezePage(3000);

            // FAQs button
            IWebElement faqsbutton = wait.Until(driver => driver.FindElement(By.LinkText("FAQs")));
            faqsbutton.Click();
            FreezePage(3000);

            // API testing button
            IWebElement apitestingbutton = wait.Until(driver => driver.FindElement(By.XPath("//span[contains(@class, 'MuiTypography-root') and text()='API Testing']")));
            apitestingbutton.Click();
            FreezePage(1000);
            
             // 1st FAQ button
            IWebElement FAQ1 = wait.Until(driver => driver.FindElement(By.XPath("//h3[contains(@class, 'MuiTypography-root') and text()='Can I use saucectl CLI to write and edit API tests?']")));
            FAQ1.Click();
            FreezePage(1000);

             // highlight the text
            IWebElement FAQ1text = wait.Until(driver => driver.FindElement(By.XPath("//a[contains(@class, 'MuiTypography-root') and text()='Sauce Piestry']")));
            jsExecutor.ExecuteScript("arguments[0].style.backgroundColor = 'yellow';", FAQ1text);
            FreezePage(3000);

            // FAQ1text button
            IWebElement FAQ1textbutton = wait.Until(driver => driver.FindElement(By.XPath("//a[contains(@class, 'MuiTypography-root') and text()='Sauce Piestry']")));
            FAQ1textbutton.Click();
            FreezePage(5000);

        }

        [TearDown]
        public void teardown() { driver.Quit(); }
    }
}