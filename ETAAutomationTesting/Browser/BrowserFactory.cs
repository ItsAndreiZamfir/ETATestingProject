using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Browser
{
    public class BrowserFactory
    {
        public static WebDriver GetBrowserService()
        {
            string browser = BrowserType.BROWSER_CHROME;

            switch(browser)
            {
                case BrowserType.BROWSER_CHROME:
                    ChromeServicies chromeService = new ChromeServicies();
                    chromeService.OpenBrowser();
                    return (WebDriver)chromeService.WebDriver;
                case BrowserType.BROWSER_EDGE:
                    EdgeServicies edgeService = new EdgeServicies();
                    edgeService.OpenBrowser();
                    return (WebDriver)new EdgeServicies().WebDriver;
                default:
                    throw new ArgumentException("Unknown browser type: " + browser);
            }
        }
    }
}
