using ETAAutomationTesting.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ETAAutomationTesting.Pages
{
    public class BasePage
    {
        private IWebDriver webDriver;
        protected ElementMethods elementMethods;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            elementMethods = new ElementMethods(webDriver);
        }

        public IWebDriver WebDriver { get { return this.webDriver; } set { this.webDriver = value; } }

        protected void WaitForPageToLoad(int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver =>
                ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete"
            );
        }
    }
}
