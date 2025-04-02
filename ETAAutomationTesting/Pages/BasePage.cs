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

        public IWebDriver StartWebDriver(String browserName)
        {
            switch(browserName)
            {
                case "chrome":
                    //ChromeOptions chromeOptions = new ChromeOptions();
                    //chromeOptions.AddArguments("--disable-popup-blocking");
                    //chromeOptions.AddArguments("--disable-extensions");
                    //chromeOptions.AddArguments("--incognito");
                    //webDriver = new ChromeDriver(chromeOptions);
                    WebDriver = new ChromeDriver();
                    break;
                case "firefox":
                    //FirefoxOptions firefoxOptions = new FirefoxOptions();
                    //firefoxOptions.AddArguments("--private");
                    //webDriver = new FirefoxDriver();
                    WebDriver = new FirefoxDriver();
                    break;
                case "edge":
                    WebDriver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Unknown browser name: " + browserName);
            }
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }

        protected void WaitForPageToLoad(int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver =>
                ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete"
            );
        }
    }
}
