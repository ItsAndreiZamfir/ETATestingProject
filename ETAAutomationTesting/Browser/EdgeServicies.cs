using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Browser
{
    public class EdgeServicies : IBrowserService
    {
        public IWebDriver WebDriver { get; private set; }
        public object BrowserOptions()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddArguments("--disable-popup-blocking");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--incognito");
            options.AddArguments("--start-maximized"); // Optional: Start browser maximized
            return options;
        }

        public void OpenBrowser()
        {
            EdgeOptions options = (EdgeOptions)BrowserOptions();
            WebDriver = new EdgeDriver(options);
        }
    }
}
