using ETAAutomationTesting.Browser;
using ETAAutomationTesting.Pages;
using OpenQA.Selenium;

namespace TestSeleniumWithC_.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        BasePage page;

        [SetUp]
        public void setup()
        {
            driver = BrowserFactory.GetBrowserService();
            Assert.NotNull(driver, "WebDriver is null");
        }

        [TearDown]
        public void tearDown()
        {
            if(driver !=null)
            {
                try
                {
                    driver.Quit();
                    driver.Dispose();
                } catch( Exception e)
                {
                    Console.WriteLine("Error closing the web driver: " + e.Message);
                }
            }
            Console.WriteLine("Test was executed successfully");
        }
    }
}
