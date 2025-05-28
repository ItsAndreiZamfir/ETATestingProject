using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Browser
{
    public class ChromeServicies : IBrowserService
    {
        public IWebDriver WebDriver { get; private set; }
        public object BrowserOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--disable-popup-blocking");
            chromeOptions.AddArguments("--disable-extensions");
            chromeOptions.AddArguments("--incognito");
            chromeOptions.AddArguments("--start-maximized"); // Optional: Start browser maximized
            chromeOptions.AddArguments("--disable-infobars"); // Optional: Disable infobars

            return chromeOptions;
        }

        public void OpenBrowser()
        {
            ChromeOptions options = (ChromeOptions)BrowserOptions();
            WebDriver = new ChromeDriver(options);
        }
    }
}
