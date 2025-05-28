using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Browser
{
    public class FirefoxServicies : IBrowserService
    {
        public IWebDriver WebDriver { get; private set; }
        public object BrowserOptions()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArguments("--disable-popup-blocking");
            firefoxOptions.AddArguments("--disable-extensions");
            firefoxOptions.AddArguments("--incognito");
            firefoxOptions.AddArguments("--start-maximized"); // Optional: Start browser maximized
            firefoxOptions.AddArguments("--disable-infobars"); // Optional: Disable infobars

            return firefoxOptions;
        }

        public void OpenBrowser()
        {
            FirefoxOptions options = (FirefoxOptions)BrowserOptions();
            WebDriver = new FirefoxDriver(options);
        }
    }
}
