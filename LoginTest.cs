using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginAutomationTest
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
        }

        [Test]
        public void ValidTestLogin()
        {
            try
            {
                // Locate and fill the username field
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");

                // Locate and fill the password field
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");

                // Click the login button
                driver.FindElement(By.Id("login-button")).Click();

                // Wait for the page to load
                System.Threading.Thread.Sleep(3000);

                // Assert that login was successful by checking for a page element
                Assert.That(driver.PageSource.Contains("Products"), Is.True, "Login failed - 'Products' text not found");
            }
            catch (Exception)
            {
                TakeScreenshot("ValidLoginTest");
                throw;
            }
        }

        [TearDown]
        public void Cleanup()
        {
            if (driver != null)
            {
                driver.Quit();   // Disposes browser session
                driver.Dispose(); // Ensures proper cleanup
            }
        }

        public void TakeScreenshot(string testName)
        {
            string path = Path.Combine(TestContext.CurrentContext.WorkDirectory, $"{testName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(path);

            TestContext.WriteLine($"Screenshot saved to: {path}");
        }
    }
}
